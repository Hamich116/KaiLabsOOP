using FirstLab.Pages;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FirstLab.GeometryClasses
{
    internal class MyRectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }

        public int Length { get; set; }

        public MyRectangle(int x, int y, int lenght, int width)
        {
            X = x;
            Y = y;
            Width = width;
            Length = lenght;
        }

        public Rectangle Show()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(X, Y, 0, 0);
            rectangle.Width = Width;
            rectangle.Height = Length;
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
                MessageBox.Show("Выберете прямоугольник, который хотите переместить, путем нажатия на прямоугольник левой кнопки мыши");
            }
        }

        public static void Resize(int lenght, int width, Rectangle rectangle)
        {
            if (rectangle != null)
            {
                rectangle.Width = Convert.ToInt32(lenght);
                rectangle.Height = Convert.ToInt32(width);
            }
            else
            {
                MessageBox.Show("Выберете прямоугольник, который хотите переместить, путем нажатия на прямоугольник левой кнопки мыши");
            }

        }

        private void Rectangle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RectanglePage.clickedThisRectangle = (Rectangle)sender;
        }
    }
}
