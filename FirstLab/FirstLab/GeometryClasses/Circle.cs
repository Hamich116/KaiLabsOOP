using FirstLab.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FirstLab.GeometryClasses
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Ellipse Show()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(X, Y, 0, 0);
            ellipse.Width = Radius;
            ellipse.Height = Radius;
            ellipse.Fill = Brushes.Black;
            ellipse.Stroke = Brushes.Red;
            ellipse.StrokeThickness = 1;
            ellipse.MouseLeftButtonDown += Ellipse_MouseLeftButtonDown;
            return ellipse;
        }

        public static void MoveTo(int x, int y, Ellipse ellipse)
        {
            if (ellipse != null)
            {
                Thickness thickness = ellipse.Margin;
                thickness.Left += Convert.ToInt32(x);
                thickness.Top += Convert.ToInt32(y);
                ellipse.Margin = thickness;
            }
            else
            {
                MessageBox.Show("Выберете круг, который хотите переместить, путем нажатия на круг левой кнопки мыши");
            }    
        }

        public static void Resize(int radius, Ellipse ellipse)
        {
            if (ellipse != null)
            {
                ellipse.Width = Convert.ToInt32(radius);
                ellipse.Height = Convert.ToInt32(radius);
            }
            else
            {
                MessageBox.Show("Выберете круг, который хотите переместить, путем нажатия на круг левой кнопки мыши");
            }
            
        }

        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CirclePage.clickedThisEllipse = (Ellipse) sender;
        }
    }
}
