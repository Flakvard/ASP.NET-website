
namespace AcmeCorporationUnitTests.Data
{
    public class ApplicationDbContextUnitTest
    {
        [Fact]
        public void EnsureInitialDataIsGenerated()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            var context = new ApplicationDbContext(options);
            var modelBuilder = new ModelBuilder();

            // Act
            ApplicationDbContext.GenerateInitialData(modelBuilder);

            // Assert
            var entries = modelBuilder.Model.GetEntityTypes();
            var serialNumberType = entries.First(e => e.ClrType == typeof(SerialNumberModel));;


            // Add assertions based on the expected data in the modelBuilder
            Assert.NotNull(entries);
            Assert.NotNull(serialNumberType);
        }

    }
}
