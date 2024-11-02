using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for OrderCrdentialsWindow.xaml
    /// </summary>
    public partial class OrderCrdentialsWindow : Window
    {
        public OrderCrdentialsWindow()
        {
            InitializeComponent();
            meme.Visibility = Visibility.Visible;
            CredentialsGrid.Visibility = Visibility.Collapsed;
        }

        private void FormInitialized(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                Dispatcher.Invoke(new Action(() =>
                {
                    meme.Visibility = Visibility.Collapsed;
                    CredentialsGrid.Visibility = Visibility.Visible;
                }));
            });
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
