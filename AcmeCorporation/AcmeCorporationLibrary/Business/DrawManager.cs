using AcmeCorporationLibrary.Data;
using AcmeCorporationLibrary.Models;

namespace AcmeCorporationLibrary.Business
{
    internal class DrawManager
    {
        private readonly IApplicationDbContext _db;
        public DrawManager(IApplicationDbContext db)
        {
            _db = db;
            InitializeSerialNumbers(); 
        }
        private List<string> validSerialNumbers;

        private void InitializeSerialNumbers()
        {
            validSerialNumbers = _db.SerialNumbers.Select(sn => sn.Guid).ToList();
        }

        public bool IsSerialNumberValid(string serialNumber)
        {
            return validSerialNumbers.Contains(serialNumber);
        }
        public SerialNumberModel GetSerialNumberModel(string serialNumber)
        {
            return _db.SerialNumbers.FirstOrDefault(sn => sn.Guid == serialNumber);
        }

        public bool CheckAndUpdateSerialNumber(string serialNumber)
        {
            if (IsSerialNumberValid(serialNumber))
            {
                SerialNumberModel serialNumberFound = GetSerialNumberModel(serialNumber);
                if (serialNumberFound != null)
                {
                    if (serialNumberFound.IsActive)
                    {
                        serialNumberFound.UpdateSerialNumber();
                        _db.SerialNumbers.Update(serialNumberFound);
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
