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
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DisplayName("Product serial number")]
        public required string ProductSerialNumber { get; set; }
        [Required(ErrorMessage = "You must be at least 18 years old.")]
        public required string IsOver18 {  get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
