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
using System.Windows.Shapes;

namespace KuznetsovAutoservice.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        int a = 0;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var user = App.context.Employees.FirstOrDefault(u => u.Login == LoginTb.Text && u.Password == PasswordPb.Password);
                if (user != null)
                {
                    App.currentEmployee = user;
                    MainWindow main = new MainWindow();
                    main.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                    LoginTb.Text = "";
                    PasswordPb.Password = "";
                    a += 1;
                    if (a == 3)
                    {
                        MessageBox.Show("Вы были заблокированы за многократные попытки входа");
                        LoginTb.IsEnabled = false;
                        PasswordPb.IsEnabled = false;
                        LoginBtn.IsEnabled = false;
                    }
                }
            }
        }
    }
}
