using System.Windows;
using System.Windows.Controls;

namespace EridanMail
{
    /// <summary>
    /// Interaction logic for PageWelcome.xaml
    /// </summary>
    public partial class PageWelcome : Page
    {
        MainWindow Form = Application.Current.Windows[0] as MainWindow;
        public PageWelcome()
        {
            InitializeComponent();
        }

        private void Button_Click_Continue(object sender, RoutedEventArgs e)
        {
            Form.frMain.Navigate(MainWindow.pageGetStarted);
        }
    }
}
