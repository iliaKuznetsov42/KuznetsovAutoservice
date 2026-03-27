using KuznetsovAutoservice.Class;
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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();

            EmployeeLv.ItemsSource = App.context.Employees.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new Pages.AddEmpPage());
        }

        private void EmployeeLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
