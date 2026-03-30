using KuznetsovAutoservice.Class;
using KuznetsovAutoservice.Model;
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

namespace KuznetsovAutoservice.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddServicePage.xaml
    /// </summary>
    public partial class AddServicePage : Page
    {
        public AddServicePage()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new ServicePage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTb.Text) && string.IsNullOrEmpty(PriceTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {
                Services services = new Services()
                {
                    ServiceName = NameTb.Text,
                    Price = Convert.ToInt32(PriceTb.Text)
                };



                App.context.Services.Add(services);
                App.context.SaveChanges();
                MessageBox.Show("Услуга добавлена");

            }
        }
    }
}
