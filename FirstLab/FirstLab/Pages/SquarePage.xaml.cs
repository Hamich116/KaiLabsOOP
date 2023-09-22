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
    /// Логика взаимодействия для SquarePage.xaml
    /// </summary>
    public partial class SquarePage : Page
    {
        public SquarePage()
        {
            InitializeComponent();
        }
        public static Rectangle clickedThisRectangle;
        private void CreateSquareClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Square square = new Square(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text), Convert.ToInt32(sideBox.Text));
                geometryPlace.Children.Add(square.Show());
                square = null;
            }
            catch
            {
                MessageBox.Show("Введите x,y и размер квадрата");
            }

        }

        private void DeletSquare(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Remove(clickedThisRectangle);
            clickedThisRectangle = null;
        }

        private void MoveSquareToAnything(object sender, RoutedEventArgs e)
        {
            try
            {
                Square.MoveTo(Convert.ToInt32(plusXBox.Text), Convert.ToInt32(plusYBox.Text), clickedThisRectangle);
            }
            catch
            {
                MessageBox.Show("Выберете квадрат, путем нажатия по нему левой кнопкой мыши, а также заполните +=x,+=y");
            }

        }

        private void ChangeSideSquare(object sender, RoutedEventArgs e)
        {
            try
            {
                Square.Resize(Convert.ToInt32(newSideBox.Text), clickedThisRectangle);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете квадрат, путем нажатия по нему левой кнопкой мыши, а также заполните новый размер стороны");
            }

        }

        private void CreateManySquare(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List<Square> list = new List<Square>();
            for (int i = 0; i < rnd.Next(2, 5); i++)
            {
                Square square = new Square(rnd.Next(-1000, 1000), rnd.Next(-500, 500), rnd.Next(10, 100));
                list.Add(square);
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
    }
}
