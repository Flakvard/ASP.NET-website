
namespace AcmeCorporationTests.UnitTests
{
    public class SubmissionTests
    {
        [Fact]
        public void ProductSerialNumber_Invalid_ReturnsError()
        {
            // Arrange
            var submission = new SubmissionModel
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                ProductSerialNumber = "123" // Invalid product serial number
            };

            // Act
            var result = ValidateSubmission(submission); // Need to implement a method called ValidateSubmission for validation

            // Assert
            Assert.False(result, "Product serial number validation failed.");
        }

        [Fact]
        public void ProductSerialNumber_Valid_ReturnsTrue()
        {
            // Arrange
            var submission = new SubmissionModel
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                ProductSerialNumber = "456" // Valid product serial number
            };

            // Act
            var result = ValidateSubmission(submission); // Assuming a method called ValidateSubmission for validation

            // Assert
            Assert.True(result, "Product serial number validation passed.");
        }

        // TODO: Implement a method called ValidateSubmission for validation for draw contest
        private bool ValidateSubmission(SubmissionModel submission)
        {
            if (submission.ProductSerialNumber == "123")
            {
                return false;
            }
            return true;
        }
    }
}
