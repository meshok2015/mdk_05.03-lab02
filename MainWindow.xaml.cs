using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;

namespace fsdfssd
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckTriangle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(SideA.Text);
                int b = int.Parse(SideB.Text);
                int c = int.Parse(SideC.Text);

                if (a + b > c && a + c > b && b + c > a)
                {
                    string triangleType;

                    if (a == b && b == c)
                        triangleType = "Равносторонний треугольник";
                    else if (a == b || b == c || a == c)
                        triangleType = "Ранвобедренный треугольник";
                    else
                        triangleType = "Разносторонний треугольник";

                    ResultText.Text = $"Полученный треугольник: {triangleType}";
                }
                else
                {
                    ResultText.Text = "треугольник с такими сторонами не существует!";
                }


                ResultText.Visibility = Visibility.Visible;
            }
            catch (FormatException)
            {
                MessageBox.Show("Подалуйста, введите  целые числа!", "ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Слишком больште числа", "ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

