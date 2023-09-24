using FirstLab.GeometryClasses;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace FirstLab.Pages
{
    /// <summary>
    /// Логика взаимодействия для RectanglePage.xaml
    /// </summary>
    public partial class RectanglePage : Page
    {
        public RectanglePage()
        {
            InitializeComponent();
        }
        public static Rectangle clickedThisRectangle;
        private void CreateRectangleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MyRectangle rectangle = new MyRectangle(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text), Convert.ToInt32(lenghtBox.Text), Convert.ToInt32(widthBox.Text));
                geometryPlace.Children.Add(rectangle.Show());
                rectangle = null;
            }
            catch
            {
                MessageBox.Show("Введите x,y и размер прямоугольника");
            }

        }

        private void DeleteRectangle(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Remove(clickedThisRectangle);
            clickedThisRectangle = null;
        }

        private void MoveRectangleToAnything(object sender, RoutedEventArgs e)
        {
            try
            {
                MyRectangle.MoveTo(Convert.ToInt32(plusXBox.Text), Convert.ToInt32(plusYBox.Text), clickedThisRectangle);
            }
            catch
            {
                MessageBox.Show("Выберете прямоугольник, путем нажатия по нему левой кнопкой мыши, а также заполните +=x,+=y");
            }

        }

        private void ChangeSideRectangle(object sender, RoutedEventArgs e)
        {
            try
            {
                MyRectangle.Resize(Convert.ToInt32(newLenghtBox.Text), Convert.ToInt32(newWidthBox.Text), clickedThisRectangle);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете прямоугольник, путем нажатия по нему левой кнопкой мыши, а также заполните новый длину и ширину");
            }

        }

        private void CreateManyRectangle(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List<MyRectangle> list = new List<MyRectangle>();
            for (int i = 0; i < rnd.Next(2, 5); i++)
            {
                MyRectangle rectangle = new MyRectangle(rnd.Next(-1000, 1000), rnd.Next(-500, 500), rnd.Next(10, 100), rnd.Next(10, 100));
                list.Add(rectangle);
            }
            foreach (var item in list)
            {
                geometryPlace.Children.Add(item.Show());
            }
            rnd = null;
            list = null;
        }

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Clear();
        }

        private void ClearObjectWhenPageNotUsed(object sender, RoutedEventArgs e)
        {
            clickedThisRectangle = null;
        }

        private void AllSizeBoxPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void AllCoordionatesBoxPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!(e.Text[0] <= 47 || e.Text[0] <= 57 && e.Text[0] != 45))
            {
                e.Handled = true;
            }
        }
    }
}
