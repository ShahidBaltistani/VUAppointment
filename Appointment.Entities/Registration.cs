using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Entities
{
    public class Registration : EntityBase
    {
        [Required]
        public int UserID { get; set; }
        public User user { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        [MaxLength(150)]
        public string SecondName { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string Contact { get; set; }
        [MaxLength(150)]
        public string Notes { get; set; }
    }
}
