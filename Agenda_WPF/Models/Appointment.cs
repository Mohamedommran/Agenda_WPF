using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_WPF.Models
{
    public class Appointment
    {
        [Key]

        public int IdAppointment { get; set; }
        public DateTime DateHour { get; set; }
    }
}
