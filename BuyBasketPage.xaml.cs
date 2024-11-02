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
    /// Логика взаимодействия для BuyBasketPage.xaml
    /// </summary>
    public partial class BuyBasketPage : Window
    {
        public BuyBasketPage()
        {
            InitializeComponent();
        }

        private void buyBasketB_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар удален из корзины.", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Warning);

            grid_1Supply.Visibility = Visibility.Hidden;
            textBlock_1Supply.Visibility= Visibility.Hidden;
        }

        private void zakazB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (grid_1Supply.Visibility == Visibility.Hidden)
                MessageBox.Show("Корзина пуста!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show("Заказ оформлен!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void newsB_Click(object sender, RoutedEventArgs e)
        {
            NewsPage newsPage = new NewsPage();
            newsPage.Show(); this.Close();
        }

        private void statB_Click(object sender, RoutedEventArgs e)
        {
            ArticlesPage articlesPage = new ArticlesPage();
            articlesPage.Show(); this.Close();
        }

        private void forumB_Click(object sender, RoutedEventArgs e)
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
            RegistrationWindow regWindow = new RegistrationWindow();
            regWindow.Show(); this.Close();
        }

        private void buyBasketB_2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар удален из корзины.", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void buyBasketB_3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар удален из корзины.", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void buyBasketB_1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар удален из корзины.", "В разработке", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
