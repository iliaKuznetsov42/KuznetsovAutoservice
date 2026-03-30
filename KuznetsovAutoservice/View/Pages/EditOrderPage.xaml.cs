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
    /// Логика взаимодействия для EditOrderPage.xaml
    /// </summary>
    public partial class EditOrderPage : Page
    {
        Orders selectedOrder;
        public EditOrderPage(Orders selectedOrder)
        {
            InitializeComponent();

            this.selectedOrder = selectedOrder;
            InitializeComponent();
            DataContext = selectedOrder;

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

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();
            MessageBox.Show("Заказ отредактирован");
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new OrderPage());
        }
    }
}
