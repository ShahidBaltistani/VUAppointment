using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Appointment.Entities
{
    public class User : EntityBase
    {
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
