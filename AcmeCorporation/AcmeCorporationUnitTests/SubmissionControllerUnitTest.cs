
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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
                ProductSerialNumber = "123" // Invalid product serial number
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
                ProductSerialNumber = "456"     // valid
            };
            var invalidSubmissionLastN = new SubmissionModel
            {
                FirstName = "John",             // valid
                LastName = "",                  // invalid
                Email = "john.doe@example.com", // valid
                ProductSerialNumber = "456"     // valid
            };
            var invalidSubmissionEmail = new SubmissionModel
            {
                FirstName = "John",             // valid
                LastName = "Doe",               // valid
                Email = "",                     // invalid
                ProductSerialNumber = "456"     // valid
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
                ProductSerialNumber = "456" // Valid product serial number
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
        public void Index_ReturnsViewResultWithSubmissionData()
        {
            // Arrange
            var mockDbContext = new Mock<IApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<SubmissionModel>>();
            var submissions = new List<SubmissionModel>
            {
                new SubmissionModel { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", ProductSerialNumber = "456" }
            }.AsQueryable();
            mockDbSet.As<IQueryable<SubmissionModel>>().Setup(m => m.Provider).Returns(submissions.Provider);
            mockDbSet.As<IQueryable<SubmissionModel>>().Setup(m => m.Expression).Returns(submissions.Expression);
            mockDbSet.As<IQueryable<SubmissionModel>>().Setup(m => m.ElementType).Returns(submissions.ElementType);
            mockDbSet.As<IQueryable<SubmissionModel>>().Setup(m => m.GetEnumerator()).Returns(submissions.GetEnumerator());
            mockDbContext.Setup(db => db.Submission).Returns(mockDbSet.Object);
            var controller = new SubmissionController(mockDbContext.Object);

            // Act
            var result = controller.Index() as ViewResult;
            var model = result.ViewData.Model as IEnumerable<SubmissionModel>;

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(model);
            Assert.Single(model);
        }
    }
}
