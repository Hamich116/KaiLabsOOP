using FirstLab.GeometryClasses;
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
    /// Логика взаимодействия для CirclePage.xaml
    /// </summary>
    public partial class CirclePage : Page
    {
        public CirclePage()
        {
            InitializeComponent();
            
        }
        public static Ellipse clickedThisEllipse;
        private void CreateCircleClick(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text), Convert.ToInt32(radiusBox.Text));
            geometryPlace.Children.Add(circle.Show());
        }

        private void Ellipse_GotMouseCapture(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Тест");
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickedThisEllipse = (Ellipse)sender;
        }

        private void DeleteCircle(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Remove(clickedThisEllipse);
        }

        private void MoveCircleToAnything(object sender, RoutedEventArgs e)
        {
            Thickness thickness = clickedThisEllipse.Margin;
            thickness.Left += Convert.ToInt32(plusXBox.Text);
            thickness.Top += Convert.ToInt32(plusYBox.Text);
            clickedThisEllipse.Margin = thickness;
        }

        private void ChangeRadiusCircle(object sender, RoutedEventArgs e)
        {
            clickedThisEllipse.Width = Convert.ToInt32(newRadiusBox.Text);
            clickedThisEllipse.Height = Convert.ToInt32(newRadiusBox.Text);
        }
    }
}
