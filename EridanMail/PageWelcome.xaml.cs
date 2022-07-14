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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            //Form.frMain.Navigate(new PageWelcome());
        }
    }
}
