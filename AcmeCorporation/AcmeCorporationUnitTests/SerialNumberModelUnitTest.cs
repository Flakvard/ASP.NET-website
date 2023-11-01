
namespace AcmeCorporationUnitTests
{
    public class SerialNumberModelUnitTest
    {

        [Fact]
        public void SerialNumber_NotActive()
        {
            var SerialNumber = new SerialNumberModel
            {
                Id = 1,
                Guid = "b8aa8726-90f7-4772-bcb4-56e25738447e",
                IsActive = true,
                ConsumeTimes = 2
            };
            SerialNumber.UpdateSerialNumber();
            SerialNumber.UpdateSerialNumber();
            Assert.False(SerialNumber.IsActive);
        }


        [Fact]
        public void SerialNumber_IsActive()
        {
            var SerialNumber = new SerialNumberModel
            {
                Id = 1,
                Guid = "b8aa8726-90f7-4772-bcb4-56e25738447e",
                IsActive = true,
                ConsumeTimes = 2
            };
            SerialNumber.UpdateSerialNumber();
            Assert.True(SerialNumber.IsActive);
        }
    }
}
