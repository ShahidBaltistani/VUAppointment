using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Entities
{
    public class Clinic : EntityBase
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(150)]
        public string ContactPerson { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
    }
}
