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
    /// Логика взаимодействия для OvalPage.xaml
    /// </summary>
    public partial class OvalPage : Page
    {
        public OvalPage()
        {
            InitializeComponent();
        }

        public static Ellipse clickedThisEllipse;
        private void CreateCircleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Oval oval = new Oval(Convert.ToInt32(xBox.Text), Convert.ToInt32(yBox.Text), Convert.ToInt32(lenghtBox.Text), Convert.ToInt32(widthBox.Text));
                geometryPlace.Children.Add(oval.Show());
                oval = null;
            }
            catch
            {
                MessageBox.Show("Введите x,y, длину и ширину");
            }

        }
        private void DeleteOval(object sender, RoutedEventArgs e)
        {
            geometryPlace.Children.Remove(clickedThisEllipse);
            clickedThisEllipse = null;
        }

        private void MoveOvalToAnything(object sender, RoutedEventArgs e)
        {
            try
            {
                Oval.MoveTo(Convert.ToInt32(plusXBox.Text), Convert.ToInt32(plusYBox.Text), clickedThisEllipse);
            }
            catch
            {
                MessageBox.Show("Выберете овал, путем нажатия по нему левой кнопкой мыши, а также заполните +=x,+=y");
            }

        }

        private void ChangeRadiusCircle(object sender, RoutedEventArgs e)
        {
            try
            {
                Oval.Resize(Convert.ToInt32(newLenghtBox.Text),Convert.ToInt32(newWidthBox.Text), clickedThisEllipse);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете овал, путем нажатия по нему левой кнопкой мыши, а также заполните новую длину и ширину");
            }

        }

        private void CreateManyCircle(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            List<Oval> list = new List<Oval>();
            for (int i = 0; i < rnd.Next(2, 5); i++)
            {
                Oval oval = new Oval(rnd.Next(-1000, 1000), rnd.Next(-500, 500), rnd.Next(10, 100), rnd.Next(10,100));
                list.Add(oval);
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
            clickedThisEllipse = null;
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
            if (!(e.Text[0] <= 47 || e.Text[0] <= 57 && e.Text[0] != 45 ))
            {
                e.Handled = true;
            }
        }
    }
}
