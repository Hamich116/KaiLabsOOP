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

namespace FirstLab.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowCirclePageClick(object sender, RoutedEventArgs e)
        {
            ObjectShowFrame.Navigate(new CirclePage());
        }

        private void ShowElipsePageClick(object sender, RoutedEventArgs e)
        {
            ObjectShowFrame.Navigate(new OvalPage());
        }

        private void ShowSquarePageClick(object sender, RoutedEventArgs e)
        {
            ObjectShowFrame.Navigate(new SquarePage());
        }

        private void ShowPramougolnikPageClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
