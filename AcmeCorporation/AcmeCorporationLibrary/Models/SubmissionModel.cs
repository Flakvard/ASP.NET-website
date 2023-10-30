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
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ProductSerialNumber { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
