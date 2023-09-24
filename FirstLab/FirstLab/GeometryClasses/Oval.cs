using FirstLab.Pages;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FirstLab.GeometryClasses
{
    internal class Oval
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Lenght { get; set; }

        public int Width { get; set; }


        public Oval(int x, int y, int lenght, int width)
        {
            X = x;
            Y = y;
            Lenght = lenght;
            Width = width;
        }

        public Ellipse Show()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(X, Y, 0, 0);
            ellipse.Width = Lenght;
            ellipse.Height = Width;
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
                MessageBox.Show("Выберете овал, который хотите переместить, путем нажатия на овал левой кнопки мыши");
            }
        }

        public static void Resize(int lenght, int width, Ellipse ellipse)
        {
            if (ellipse != null)
            {
                ellipse.Width = Convert.ToInt32(width);
                ellipse.Height = Convert.ToInt32(lenght);
            }
            else
            {
                MessageBox.Show("Выберете овал, который хотите переместить, путем нажатия на овал левой кнопки мыши");
            }

        }

        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OvalPage.clickedThisEllipse = (Ellipse)sender;
        }
    }
}
