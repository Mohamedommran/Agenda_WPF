using Agenda_WPF.Data;
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

namespace Agenda_WPF
{
    /// <summary>
    /// Interaction logic for Broker.xaml
    /// </summary>
    public partial class Broker : Page
    {

        private readonly agendaContext _context;
        //private agendaContext db = new agendaContext();

        public Broker(agendaContext context)
        {
            _context = context;

            InitializeComponent();
            //agendaContext db = new agendaContext();
            var brokers = from m in _context.Customers select m;
            brokerDG.ItemsSource = brokers.ToList(); 
        }
    }
}
