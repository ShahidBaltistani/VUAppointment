using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Appointment.Entities
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime RowAddDate { get; set; }
        [Required]
        public string RowAddUser { get; set; }
        public DateTime RowEditDate { get; set; }
        public string RowEditUser { get; set; }
    }
}
