using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tihonova_demo.Models;

namespace Tihonova_demo
{
    /// <summary>
    /// Логика взаимодействия для AddEditClientWindow.xaml
    /// </summary>
    public partial class AddEditClientWindow : Window
    {
        private  Client _currentClient = new Client();
        public AddEditClientWindow(Client selectedClient)
        {
            InitializeComponent();
            if (selectedClient != null)
            {
                _currentClient = selectedClient;
            }
            DataContext = _currentClient;
            CardCB.ItemsSource = Tihonova_demoContext.GetContext().Client.Select(c => c.BonusCard).Distinct().ToList();
        }

        

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentClient.FirstName))
            {
                errors.AppendLine("Введите фамилию клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.LastName))
            {
                errors.AppendLine("Введите имя клиента");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClient.ClientId == 0)
            {
                Tihonova_demoContext.GetContext().Client.Add(_currentClient);
                try
                {
                    Tihonova_demoContext.GetContext().SaveChanges();
                    MessageBox.Show("Сохранено");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
