using System.Windows;
using System.Windows.Controls;

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
            ObjectShowFrame.Navigate(new RectanglePage());
        }
    }
}
