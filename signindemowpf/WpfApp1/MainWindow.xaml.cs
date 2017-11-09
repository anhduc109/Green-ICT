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

namespace WpfApp1
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

        private void alo123(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3();
            myframe.NavigationService.Navigate(p3);
            btlogin.Visibility = Visibility.Collapsed;
            txtusername.Visibility = Visibility.Collapsed;
            password.Visibility = Visibility.Collapsed;
            checkname.Visibility = Visibility.Collapsed;
        }

        private void myframe_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkname_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
