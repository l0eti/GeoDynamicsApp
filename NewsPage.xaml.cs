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
    /// Логика взаимодействия для NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Window
    {
        public NewsPage()
        {
            InitializeComponent();
        }

        private void pod1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В настоящее время данная функция находится в разработке!", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void statB_Click(object sender, RoutedEventArgs e)
        {
            ArticlesPage articlesPage = new ArticlesPage();
            articlesPage.Show(); this.Close();
        }

        private void forumB_Click_1(object sender, RoutedEventArgs e)
        {
            ForumPage forumPage = new ForumPage();
            forumPage.Show(); this.Close();
        }

        private void marketB_Click(object sender, RoutedEventArgs e)
        {
            MarketPage marketPage = new MarketPage();
            marketPage.Show(); this.Close();
        }

        private void logB_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show(); this.Close();
        }

        private void regB_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show(); this.Close();
        }

        private void newsB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
