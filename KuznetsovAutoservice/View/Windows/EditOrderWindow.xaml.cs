using KuznetsovAutoservice.Class;
using KuznetsovAutoservice.Model;
using KuznetsovAutoservice.View.Pages;
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
using System.Windows.Shapes;

namespace KuznetsovAutoservice.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        Orders selectedOrder;
        public EditOrderWindow(Orders selectedOrder)
        {

            InitializeComponent();
            this.selectedOrder = selectedOrder;
            DataContext = selectedOrder;

            ServiceCmb.SelectedValuePath = "ServiceID";
            ServiceCmb.DisplayMemberPath = "ServiceName";
            ServiceCmb.SelectedIndex = 0;
            ServiceCmb.ItemsSource = App.context.Services.ToList();

            EmployeeCmb.SelectedValuePath = "EmployeeID";
            EmployeeCmb.DisplayMemberPath = "Position";
            EmployeeCmb.SelectedIndex = 0;
            EmployeeCmb.ItemsSource = App.context.Employees.ToList();

            CarCmb.SelectedValuePath = "CarID";
            CarCmb.DisplayMemberPath = "Brand";
            CarCmb.SelectedIndex = 0;
            CarCmb.ItemsSource = App.context.Cars.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();
            App.context.Entry(selectedOrder).Reference(t => t.Services).Load();
            App.context.Entry(selectedOrder).Reference(t => t.Employees).Load();
            App.context.Entry(selectedOrder).Reference(t => t.Cars).Load();
            MessageBox.Show("Заказ отредактирован");
            DialogResult = true;
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new OrderPage());
        }
    }
}
