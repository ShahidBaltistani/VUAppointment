using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Entities
{
    public class Doctor : EntityBase
    {
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        public int? DesignationID { get; set; }
        public int? DepartmentID { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }

    }
}
