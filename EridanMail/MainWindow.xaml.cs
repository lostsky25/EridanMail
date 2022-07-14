using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PageWelcome pageWelcome;
        public MainWindow()
        {
            InitializeComponent();
            pageWelcome = new PageWelcome();
            frMain.Navigate(pageWelcome);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Users\User\Desktop\chromewin\chrome.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process p = new Process();
            startInfo.Arguments = "--app=https://google.com";
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();

            return;
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void gridTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_LocationChanged(object sender, EventArgs e)
        {
            xmlMainWindow.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void xmlMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            xmlMainWindow.BorderThickness = new Thickness(1, 1, 1, 1);
        }

        private void xmlMainWindow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            xmlMainWindow.BorderThickness = new Thickness(1, 1, 1, 1);
        }
    }
}
