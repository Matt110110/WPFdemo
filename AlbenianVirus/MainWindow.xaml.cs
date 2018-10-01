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


/**
 * I made this app to learn more about WPF and how they work.
 * So far, they appear to be better than Windows forms and I will explore more by making more such useless apps.
 * 
 * This app is utterly useless and was made for fun.
 * I do not intend to offend anyone from the country of Albania. That is not my intention and hope people take it with humor.
 * But still, I am sorry if I offended you.
 */
namespace AlbenianVirus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            // Closes the WPF form.
            Close();
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Opens the C:\Program Files folder in a new window.
             * This will work on all windows computers because in both x86 and x64 C:\Program Files is present.
             */
            Process.Start(@"C:\Program Files");
        }
    }
}
