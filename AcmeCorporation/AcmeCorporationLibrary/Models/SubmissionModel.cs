﻿using System.ComponentModel.DataAnnotations;

namespace AcmeCorporationLibrary.Models
{
    public class SubmissionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ProductSerialNumber { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
