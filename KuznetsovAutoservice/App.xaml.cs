using KuznetsovAutoservice.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KuznetsovAutoservice
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AutoServiceKuznetsovDBEntities context = new AutoServiceKuznetsovDBEntities();
    }
}
