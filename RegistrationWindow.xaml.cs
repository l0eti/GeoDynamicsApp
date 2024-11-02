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

namespace GeoDynamicsApp
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void regB_Click(object sender, RoutedEventArgs e)
        {
            NewsPage newsPage = new NewsPage();
            newsPage.Show(); this.Close();
        }

        private void logIn_1_Click(object sender, RoutedEventArgs e)
        {
            LogIn logInUser = new LogIn();
            logInUser.Show();
            this.Close();

        }

        private void log_Redactor_Click(object sender, RoutedEventArgs e)
        {
            LogIn_Redactor logIn_Redactor = new LogIn_Redactor();
            logIn_Redactor.Show();
            this.Close();
        }
    }
}
