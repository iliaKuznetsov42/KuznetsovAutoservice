using KuznetsovAutoservice.Class;
using KuznetsovAutoservice.Model;
using KuznetsovAutoservice.View.Windows;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            LoadOrders();

            OrderLv.ItemsSource = App.context.Orders.ToList();
        }

        private void LoadOrders()
        {
            OrderLv.ItemsSource = App.context.Orders.ToList();
        }

        private void BackBrn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new AddOrderPage());
        }

        private void EditOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Orders selectedOrder = OrderLv.SelectedItem as Orders;
            if (selectedOrder != null)
            {
                EditOrderWindow editOrderWindow = new EditOrderWindow(selectedOrder);
                
                if (editOrderWindow.ShowDialog() == true)
                {
                    OrderLv.ItemsSource = App.context.Orders.ToList();
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите заказ");
            }
        }
    }
}
