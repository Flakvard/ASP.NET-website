using AcmeCorporationLibrary.Models;

namespace AcmeCorporationLibrary.Business
{
    public interface IDrawManager
    {
        public bool IsSerialNumberValid(string serialNumber);
        public SerialNumberModel GetSerialNumberModel(string serialNumber);
        public bool CheckAndUpdateSerialNumber(string serialNumber);

    }
}
