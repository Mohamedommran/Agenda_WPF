using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_WPF.Data;

namespace Agenda_WPF.Models
{
     internal class Broker
    {
        [Key]

        public int IdBroker { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
