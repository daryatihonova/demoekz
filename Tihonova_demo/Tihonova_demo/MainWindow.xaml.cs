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
using Tihonova_demo.Models;

namespace Tihonova_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClientLV.ItemsSource = Tihonova_demoContext.GetContext().ContractCientRoom.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditClientWindow addEditClientWindow = new AddEditClientWindow(null);
            this.Close();
            addEditClientWindow.Show();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditClientWindow addEditClientWindow = new AddEditClientWindow((sender as Button).DataContext as Client);
            this.Close();
            addEditClientWindow.Show();
        }
    }
}
