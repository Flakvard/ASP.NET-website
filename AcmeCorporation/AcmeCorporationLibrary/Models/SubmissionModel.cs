using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace AcmeCorporationLibrary.Models
{
    public class SubmissionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First name")]
        public required string FirstName { get; set; }
        [Required]
        [DisplayName("Last name")]
        public required string LastName { get; set; }
        //[Required]
        //[Range(18,120)]
        //public required uint Age { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        [DisplayName("Product serial number")]
        public required string ProductSerialNumber { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
