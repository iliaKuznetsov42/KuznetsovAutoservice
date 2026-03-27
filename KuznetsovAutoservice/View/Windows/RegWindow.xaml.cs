using KuznetsovAutoservice.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();



        }

        private void Зарегестрировать_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password)
                && string.IsNullOrEmpty(NameTb.Text) && string.IsNullOrEmpty(SalaryTb.Text)
                && string.IsNullOrEmpty(SecondNameTb.Text) && string.IsNullOrEmpty(PositionTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Employees employees = new Employees()
                {
                    Login = LoginTb.Text,
                    Password = PasswordPb.Password,
                    FirstName = NameTb.Text,
                    LastName = SecondNameTb.Text,
                    Salary = Convert.ToInt32(SalaryTb.Text),
                    Position = PositionTb.Text
                };
                
                App.context.Employees.Add(employees);
                App.context.SaveChanges();
            }

            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
