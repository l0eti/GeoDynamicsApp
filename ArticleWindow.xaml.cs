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
    /// Interaction logic for ArticleWindow.xaml
    /// </summary>
    public partial class ArticleWindow : Window
    {
        private Article _article;

        public ArticleWindow(Article article)
        {
            InitializeComponent();
            _article = article;

            if (_article == null)
            {
                MessageBox.Show(
                    "Задайте статью объектом Article!",
                    "Демо",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                return;
            }
            
            Title = _article.Title;
            TitleTextBlock.Text = _article.Title;
            ContentsTextBlock.Text = _article.Contents;
        }
    }
}
