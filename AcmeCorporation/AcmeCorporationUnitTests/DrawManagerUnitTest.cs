using AcmeCorporationLibrary.Business;


namespace AcmeCorporationUnitTests
{
    public class DrawManagerUnitTest
    {


        [Fact]
        public void DrawManager_IsSerialNumberValid()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                context.SerialNumbers.AddRange(
                   new SerialNumberModel
                   {
                       Id = 1,
                       Guid = "b8aa8726-90f7-4772-bcb4-56e25738447e",
                       ConsumeTimes = 2,
                       IsActive = true
                   }
                );
                context.SaveChanges();
            }

            var dbContext = new ApplicationDbContext(options);
            var drawManager = new DrawManager(dbContext);


            // Act
            bool resultSucceeds = drawManager.IsSerialNumberValid("b8aa8726-90f7-4772-bcb4-56e25738447e");
            bool resultFails = drawManager.IsSerialNumberValid("77-b-7e");


            // Assert
            Assert.NotNull(resultSucceeds);
            Assert.True(resultSucceeds);
            Assert.False(resultFails);
        }
        [Fact]
        public void DrawManager_GetSerialNumberModel()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                context.SerialNumbers.AddRange(
                   new SerialNumberModel
                   {
                       Id = 2,
                       Guid = "1d7c6296-e8d5-4e73-aa92-446a6b0505d0",
                       ConsumeTimes = 1,
                       IsActive = true
                   }
                );
                context.SaveChanges();
            }

            var dbContext = new ApplicationDbContext(options);
            var drawManager = new DrawManager(dbContext);


            // Act
            SerialNumberModel resultObj = drawManager.GetSerialNumberModel("1d7c6296-e8d5-4e73-aa92-446a6b0505d0");


            // Assert
            Assert.NotNull(resultObj);
            Assert.Equal(2, resultObj.Id);
            Assert.Equal("1d7c6296-e8d5-4e73-aa92-446a6b0505d0", resultObj.Guid);
            Assert.Equal(1u, resultObj.ConsumeTimes);
            Assert.Equal(true, resultObj.IsActive);
        }

        }
}
