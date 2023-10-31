using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCorporationLibrary.Models
{
    public class SerialNumberModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Guid { get; set; }
        public bool IsActive { get; set; }
        public uint ConsumeTimes { get; set; }
        private bool IsConsumptionLeft()
        {
            if (ConsumeTimes == 0)
            {
                IsActive = false;
                return false;
            }
            return true;
          
        }
        public void UpdateSerialNumber()
        {
            if (IsConsumptionLeft())
            {
                ConsumeTimes--;
            }
        }

    }
}
