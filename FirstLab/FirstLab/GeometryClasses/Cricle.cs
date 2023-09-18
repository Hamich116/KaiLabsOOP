using FirstLab.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ellipse.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            ellipse.Width = Radius;
            ellipse.Height = Radius;
            ellipse.Fill = Brushes.Black;
            ellipse.Stroke = Brushes.Red;
            ellipse.StrokeThickness = 1;
            ellipse.MouseLeftButtonDown += Ellipse_MouseLeftButtonDown;
            return ellipse;
        }

        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CirclePage.clickedThisEllipse = (Ellipse) sender;
        }
    }
}
