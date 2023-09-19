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
            Circle.MoveTo(Convert.ToInt32(plusXBox.Text), Convert.ToInt32(plusYBox.Text), clickedThisEllipse);
        }

        private void ChangeRadiusCircle(object sender, RoutedEventArgs e)
        {
            Circle.Resize(Convert.ToInt32(newRadiusBox.Text), clickedThisEllipse);
        }

        private void CreateManyCircle(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List <Circle> list = new List<Circle>();
            for (int i = 0; i < rnd.Next(2,5); i++)
            {
                Circle circle = new Circle(rnd.Next(-1000,1000), rnd.Next(-500,500), rnd.Next(10,100));
                list.Add(circle);
            }
            foreach (var item in list)
            {
               geometryPlace.Children.Add(item.Show());
            }
        }

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Clear();
        }
    }
}
