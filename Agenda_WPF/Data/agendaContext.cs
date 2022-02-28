using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_WPF.Models;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Agenda_WPF.Data
{
    public partial class agendaContext : DbContext
    {
        public agendaContext()
        {

        }
        public agendaContext(DbContextOptions<agendaContext> options) : base(options)
        {
        }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;Database=agendaWPF;Trusted_Connection=True;");
                base.OnConfiguring(optionsBuilder);
            }
        }

    }
}

