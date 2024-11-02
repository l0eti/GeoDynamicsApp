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
            int newsId = Convert.ToInt32((string)((sender as Button).Tag)); 

            switch (newsId)
            {
                case 1:
                    new ArticleWindow(new Article()
                    {
                        Id = 1,
                        Title = "Аэродром Якутск",
                        Contents = "В соответствии с техническим заданием были предусмотрены работы:\r\n• Проведение геодезической съемки аэронавигационных ориентиров (АНО) и\r\nпрепятствий (обновление данных) на приаэродромной территории аэродрома Якутск\r\nв системе координат ПЗ-90.11 (WGS-84).\r\n• Проведение экспертизы результатов геодезической съёмки в ФГУП ГосНИИ ГА.\r\n• Подготовка Акта обследования препятствий в районе аэродрома с графическим\r\nматериалом в соответствии с МОС ФАП-262.\r\n• Расчет минимальных безопасных высот пролета препятствий для захода на посадку\r\nвоздушных судов (ОСА/ОСН);\r\n• Короткошаговое нивелирование трех продольных профилей ИВПП-2 аэродрома\r\nЯкутск, подготовка данных и разработка Заключения о ровности ИВПП аэродрома;\r\n• Подготовка комплекта доказательной документации для сертификации аэродрома\r\nЯкутск, включая разработку Заключений о классе аэродрома и прочности\r\nискусственных покрытий реконструированных элементов аэродрома в соответствии с\r\nтребованиями ФАП-262, МОС ФАП-262."
                    }).Show();
                    break;
                case 2:
                    new ArticleWindow(new Article()
                    {
                        Id = 1,
                        Title = "Аэродром Пулково",
                        Contents = "Для обеспечения безопасности полетов и движения воздушных судов по летному полю, получение качественной и достоверной геопространственной информации становится весьма актуальной  задачей. Для крупного города любая информация о высотном строительстве в пределах приаэродромной территории должна оперативно оцениваться. На протяжении многих лет ООО «Геодинамика-М» проводит ежегодное обслуживание аэродрома «Пулково», включая обновление информации по строительству высотных объектов и оценку их влияния на безопасность движения воздушных судов. Ежегодно проводится работа и по обновлению аэродромной картографической базы (AMDB)."
                    }).Show();
                    break;
                case 3:
                    new ArticleWindow(new Article()
                    {
                        Id = 1,
                        Title = "Аэропорт Победилово",
                        Contents = "ООО «Геодинамика–М» заключило договор с АО «Аэропорт Победилово» на выполнение Комплекса работ по подготовке геопространственной информации по аэродрому Киров (Победилово), формированию документов аэронавигационной информации в соответствии с приказом Министерства транспорта № 305 от 31.10.2014 г. и доказательной документации для сертификации аэродрома в соответствии с приказом Министерства транспорта № 262 от 25.08.2015 г."
                    }).Show();
                    break;

            }
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
