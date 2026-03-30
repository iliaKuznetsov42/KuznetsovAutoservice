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
    /// Логика взаимодействия для AddEmpPage.xaml
    /// </summary>
    public partial class AddEmpPage : Page
    {
        public AddEmpPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTb.Text) && string.IsNullOrEmpty(SurnameTb.Text) && string.IsNullOrEmpty(PositionTb.Text) && string.IsNullOrEmpty(SalaryTb.Text) && string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Заполните все поля");
            }

            else
            {
                Employees employees = new Employees()
                {
                    FirstName = NameTb.Text,
                    LastName = SurnameTb.Text,
                    Position = PositionTb.Text,
                    Salary = Convert.ToInt32(SalaryTb.Text),
                    Login = LoginTb.Text,
                    Password = PasswordPb.Password

                };

                App.context.Employees.Add(employees);
                App.context.SaveChanges();
                MessageBox.Show("Работник добавлен");

            }
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new EmployeePage());
        }
    }
}
