using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Agenda_WPF.Data;

namespace Agenda_WPF
{
    /// <summary>
    /// Interaction logic for customer.xaml
    /// </summary>
    public partial class customer : Page
    {
        public readonly agendaContext _context;
        public customer(agendaContext context)
        {
            this.DataContext=context;
            _context = context;
            InitializeComponent();
            //_context = new agendaContext();
            GetCustomers();

        }
        //public customer( agendaContext dbContext)
        //{
        //    InitializeComponent();
        //    //_dbContext = dbContext;
        //    _dbContext = new agendaContext();
        //    GetProducts();
        //}
        private void GetCustomers()
        {
            var cust = from d in _context.Customers select d;
            foreach (var item in _context.Customers)
            {
                Console.WriteLine(item.FirstName);
            }

            customerDG.ItemsSource = _context.Customers.ToList();
        }
    }
}
