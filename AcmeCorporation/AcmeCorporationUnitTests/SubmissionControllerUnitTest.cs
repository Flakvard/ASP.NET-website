
namespace AcmeCorporationTests.UnitTests
{
    public class SubmissionControllerTests
    {
        [Fact]
        public void SubmitForm_WithInvalidSerialNumber_ReturnsViewWithModelError()
        {
            // Arrange
            var mockDbContext = new Mock<IApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<SubmissionModel>>();
            mockDbContext.Setup(db => db.Submission).Returns(mockDbSet.Object);
            var controller = new SubmissionController(mockDbContext.Object);
            var invalidSubmission = new SubmissionModel
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                ProductSerialNumber = "123", // Invalid product serial number
                IsOver18 = true
            };

            // Act
            var result = controller.SubmitForm(invalidSubmission) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.True(result.ViewData.ModelState.ContainsKey("ProductSerialNumber"));
            Assert.True(result.ViewData.ModelState.IsValid.Equals(false));
        }

        // Server-side validation checks on form
        [Fact]
        public void SubmitForm_WithInvalidInfo_ReturnsViewWithModelError()
        {
            // Arrange
            var mockDbContext = new Mock<IApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<SubmissionModel>>();
            mockDbContext.Setup(db => db.Submission).Returns(mockDbSet.Object);
            var controller = new SubmissionController(mockDbContext.Object);
            var invalidSubmissionFirstN = new SubmissionModel
            {
                FirstName = "",                 // invalid
                LastName = "Doe",               // valid
                Email = "john.doe@example.com", // valid
                ProductSerialNumber = "456",     // valid
                IsOver18 = true                 // valid
            };
            var invalidSubmissionLastN = new SubmissionModel
            {
                FirstName = "John",             // valid
                LastName = "",                  // invalid
                Email = "john.doe@example.com", // valid
                ProductSerialNumber = "456",    // valid
                IsOver18 = true                 // valid
            };
            var invalidSubmissionEmail = new SubmissionModel
            {
                FirstName = "John",             // valid
                LastName = "Doe",               // valid
                Email = "",                     // invalid
                ProductSerialNumber = "456",     // valid
                IsOver18 = true                 // valid
            };

            // Act
            var resultF = controller.SubmitForm(invalidSubmissionFirstN) as ViewResult;
            var resultL = controller.SubmitForm(invalidSubmissionLastN) as ViewResult;
            var resultE = controller.SubmitForm(invalidSubmissionEmail) as ViewResult;


            // Assert
            Assert.NotNull(resultF);
            Assert.False(resultF.ViewData.ModelState.IsValid);
            Assert.True(resultF.ViewData.ModelState.ContainsKey("FirstName")); // Assert that an error message is added for FirstName

            Assert.NotNull(resultL);
            Assert.False(resultL.ViewData.ModelState.IsValid);
            Assert.True(resultL.ViewData.ModelState.ContainsKey("LastName")); // Assert that an error message is added for LastName

            Assert.NotNull(resultE);
            Assert.False(resultE.ViewData.ModelState.IsValid);
            Assert.True(resultE.ViewData.ModelState.ContainsKey("Email")); // Assert that an error message is added for LastName

        }

        [Fact]
        public void SubmitForm_WithValidSubmission_ReturnsRedirectToActionResult()
        {
            // Arrange
            var mockTempData = new Mock<ITempDataDictionary>();
            var mockDbContext = new Mock<IApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<SubmissionModel>>();
            mockDbContext.Setup(db => db.Submission).Returns(mockDbSet.Object);
            var controller = new SubmissionController(mockDbContext.Object);
            controller.TempData = mockTempData.Object;
            var validSubmission = new SubmissionModel
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                ProductSerialNumber = "456", // Valid product serial number
                IsOver18 = true
            };

            // Act
            var result = controller.SubmitForm(validSubmission) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);

            // Verify that TempData has been set
            mockTempData.VerifySet(t => t["success"] = "Form was submitted successfully");
        }
        
        [Fact]
        public async Task GetSubmissions_ReturnsJsonResultWithSubmissionData()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                context.Submission.AddRange(
                   new SubmissionModel { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", ProductSerialNumber = "456", IsOver18 = true },
                   new SubmissionModel { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", ProductSerialNumber = "789", IsOver18 = true }
                );  
                context.SaveChanges();
            }
            

            var dbContext = new ApplicationDbContext(options);
            var controller = new SubmissionController(dbContext);

            // Act
            var result = await controller.GetSubmissions();

            // Assert
            var jsonResult = Assert.IsType<JsonResult>(result);
            dynamic data = jsonResult.Value;
            var submissions = ((IEnumerable<object>)data.GetType().GetProperty("Submissions").GetValue(data, null)).ToList();
            Assert.NotNull(submissions);

            var firstSubmission = (SubmissionModel)submissions[0];
            var secondSubmission = (SubmissionModel)submissions[1];

            // Assert the first submission
            Assert.Equal("John", firstSubmission.FirstName);
            Assert.Equal("Doe", firstSubmission.LastName);
            Assert.Equal("john.doe@example.com", firstSubmission.Email);
            Assert.Equal("456", firstSubmission.ProductSerialNumber);

            // Assert the second submission
            Assert.Equal("Jane", secondSubmission.FirstName);
            Assert.Equal("Smith", secondSubmission.LastName);
            Assert.Equal("jane.smith@example.com", secondSubmission.Email);
            Assert.Equal("789", secondSubmission.ProductSerialNumber);
        }

        [Fact]
        public void Index_ReturnsViewResultWithoutSubmissionData()
        {
            // Arrange
            var mockDbContext = new Mock<IApplicationDbContext>();
            var controller = new SubmissionController(mockDbContext.Object);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Null(result.ViewData.Model);
        }
    }
}
