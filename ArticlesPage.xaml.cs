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
    /// Логика взаимодействия для ArticlesPage.xaml
    /// </summary>
    public partial class ArticlesPage : Window
    {
        public ArticlesPage()
        {
            InitializeComponent();

            enterSearchImageButton.Visibility = Visibility.Visible;
            clearSearchImageButton.Visibility = Visibility.Visible;
        }

        private void marketB_Click(object sender, RoutedEventArgs e)
        {
            MarketPage marketPage = new MarketPage();
            marketPage.Show();
            this.Close();
        }

        private void clearSearchImageButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (searchBox.Text != "Поиск" && searchBox.Foreground != Brushes.Gray)
                searchBox.Text = "";
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("В настоящее время данная функция находится в разработке!", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Поиск" && searchBox.Foreground == Brushes.Gray)
            {
                searchBox.Text = "";
                searchBox.Foreground = Brushes.Black;
            }
        }

        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Foreground = Brushes.Gray;
                searchBox.Text = "Поиск";
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void forumB_Click_1(object sender, RoutedEventArgs e)
        {
            ForumPage forumPage = new ForumPage();
            forumPage.Show(); this.Close();
        }

        private void statB_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void pod1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В настоящее время данная функция находится в разработке!", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void pod2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В настоящее время данная функция находится в разработке!", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void newsB_Click(object sender, RoutedEventArgs e)
        {
            NewsPage newsPage= new NewsPage();
            newsPage.Show(); this.Close();
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
    }
}
