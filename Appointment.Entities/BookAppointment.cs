using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Entities
{
    public class BookAppointment : EntityBase
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public int ClinicID { get; set; }
        [Required]
        public int DoctorID { get; set; }
        public AppointmentEnums AppointmentType { get; set; }
        [MaxLength(150)]
        public string Notes { get; set; }

    }
}
