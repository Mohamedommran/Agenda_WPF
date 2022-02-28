using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_WPF.Models
{
    public class Customer
    {
        [Key]
        [Column("idCustomer")]

        public int IdCustomer { get; set; }

        [Column("lastName")]
        public string? LastName { get; set; }

        [Column("firstName")]
        public string? FirstName { get; set; }

        [Column("mail")]
        public string? Mail { get; set; }

        [Column("phone")]
        public string? PhoneNumber { get; set; }

        [Column("budget")]
        public int Budget { get; set; }
    }
}
