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
using Agenda_WPF.Models;

namespace Agenda_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        agendaContext dbContext;
        public MainWindow()
        {
            this.dbContext = dbContext;
            InitializeComponent();
        }
        private void GetCustomers()
        {
            
            //customer.ItemsSource = dbContext.customers.ToList();

        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {

        }
        private void customerList_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Customer.xaml", UriKind.RelativeOrAbsolute));

        }

        private void brokerList_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Broker.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
