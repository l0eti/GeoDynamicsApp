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
            new ArticleWindow(new Article()
            {
                Id = 1,
                Title = "АМФИБОЛ-ФЛОГОПИТСОДЕРЖАЩИЕ КСЕНОЛИТЫ",
                Contents = "Амфибол-флогопитсодержащие ксенолиты из кимберлитов как свидетельство метасоматических процессов в литосферной мантии под Куойкским кимберлитовым полем\r\n\r\nКимберлиты, образующиеся в глубоких слоях Земли, являются важными индикаторами геологических процессов в литосферной мантии. Особенно интересны амфибол-флогопитсодержащие ксенолиты, которые свидетельствуют о метасоматических процессах — изменениях состава пород под воздействием флюидов. Эти ксенолиты могут указывать на взаимодействие магмы с мантией и присутствие флюидов в глубоких слоях Земли.\r\n\r\nКуойкское кимберлитовое поле представляет собой одно из наиболее изученных месторождений кимберлитов, где встречаются такие ксенолиты. Геохимический анализ этих образцов позволяет определить условия их формирования и состав участвующих флюидов, что помогает понять механизмы миграции флюидов в мантии. Исследования показывают, что амфиболы и флогопиты формировались при высоких температурах и давлениях, указывая на активные метасоматические процессы.\r\n\r\nТаким образом, амфибол-флогопитсодержащие ксенолиты из Куойкского кимберлитового поля являются ценным материалом для изучения динамики мантии и взаимодействия между магматическими и метасоматическими процессами, что углубляет наши знания о структуре и составе литосферной мантии."
            }).Show();
        }

        private void pod2_Click(object sender, RoutedEventArgs e)
        {
            new ArticleWindow(new Article()
            {
                Id = 2,
                Title = "ТЕРМОБАРОМЕТРИЯ ДЕПЛЕТИРОВАННЫХ ПЕРИДОТИТОВ",
                Contents = "Термобарометрия — важный инструмент в геодинамике, позволяющий исследовать условия образования горных пород на значительных глубинах. Деплетированные перидотипы, состоящие преимущественно из оливина и пироксена, представляют особый интерес, так как в них наблюдается снижение содержания алюминия и других элементов, что может быть вызвано частичным плавлением или метаморфизмом.\r\n\r\nМетоды термобарометрии позволяют определить температуру и давление, при которых образовались эти породы, а также реконструировать термодинамические пути их эволюции. Это помогает понять процессы в мантии Земли и их связь с тектоническими явлениями на поверхности.\r\n\r\nИзучение термобарометрии деплетированных перидотипов имеет большое значение для понимания динамики мантии и ее взаимодействия с литосферой. Результаты таких исследований могут пролить свет на механизмы формирования магматических тел и предсказать геологические процессы, такие как вулканическая активность и землетрясения."
            }).Show();
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
