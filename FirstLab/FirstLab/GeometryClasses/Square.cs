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
    internal class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Sides { get; set; }

        public Square(int x, int y, int sides)
        {
            X = x;
            Y = y;
            Sides = sides;
        }

        public Rectangle Show()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(X, Y, 0, 0);
            rectangle.Width = Sides;
            rectangle.Height = Sides;
            rectangle.Fill = Brushes.Red;
            rectangle.Stroke = Brushes.Black;
            rectangle.StrokeThickness = 1;
            rectangle.MouseLeftButtonDown += Rectangle_MouseLeftButtonDown;
            return rectangle;
        }

        public static void MoveTo(int x, int y, Rectangle rectangle)
        {
            if (rectangle != null)
            {
                Thickness thickness = rectangle.Margin;
                thickness.Left += Convert.ToInt32(x);
                thickness.Top += Convert.ToInt32(y);
                rectangle.Margin = thickness;
            }
            else
            {
                MessageBox.Show("Выберете квадрат, который хотите переместить, путем нажатия на круг левой кнопки мыши");
            }
        }

        public static void Resize(int side, Rectangle rectangle)
        {
            if (rectangle != null)
            {
                rectangle.Width = Convert.ToInt32(side);
                rectangle.Height = Convert.ToInt32(side);
            }
            else
            {
                MessageBox.Show("Выберете квадрат, который хотите переместить, путем нажатия на круг левой кнопки мыши");
            }

        }

        private void Rectangle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SquarePage.clickedThisRectangle = (Rectangle)sender;
        }
    }
}
