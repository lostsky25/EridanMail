using System.Windows;
using System.Windows.Controls;

namespace EridanMail
{
    /// <summary>
    /// Interaction logic for PageGetStarted.xaml
    /// </summary>
    public partial class PageGetStarted : Page
    {
        MainWindow Form = Application.Current.Windows[0] as MainWindow;
        public PageGetStarted()
        {
            InitializeComponent();
        }

        private void Button_Click_Continue(object sender, System.Windows.RoutedEventArgs e)
        {
            Form.frMain.Navigate(MainWindow.pageAddAccount);
        }
    }
}
