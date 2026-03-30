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
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public AddOrderPage()
        {
            InitializeComponent();

            ServiceCmb.SelectedValuePath = "ServiceID";
            ServiceCmb.DisplayMemberPath = "ServiceName";
            ServiceCmb.ItemsSource = App.context.Services.ToList();

            EmployeeCmb.SelectedValuePath = "EmployeeID";
            EmployeeCmb.DisplayMemberPath = "Position";
            EmployeeCmb.ItemsSource = App.context.Employees.ToList();

            CarCmb.SelectedValuePath = "CarID";
            CarCmb.DisplayMemberPath = "Brand";
            CarCmb.ItemsSource = App.context.Cars.ToList();

        }


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ServiceCmb.Text) && string.IsNullOrEmpty(EmployeeCmb.Text) && string.IsNullOrEmpty(CarCmb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {
                Orders orders = new Orders()
                {
                    Services = ServiceCmb.SelectedItem as Services,
                    Employees = EmployeeCmb.SelectedItem as Employees,
                    Cars = CarCmb.SelectedItem as Cars
                };

                App.context.Orders.Add(orders);
                App.context.SaveChanges();
                MessageBox.Show("Заказ добавлен");
            }
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new OrderPage());
        }
    }
}
