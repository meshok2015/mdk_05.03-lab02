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
                        triangleType = "Ravnostoroni treugolnik";
                    else if (a == b || b == c || a == c)
                        triangleType = "Ravnobedreni treugolnik";
                    else
                        triangleType = "Rasnostoroni treugolnik";

                    ResultText.Text = $"Polucheni treugolnik: {triangleType}";
                }
                else
                {
                    ResultText.Text = "treugolnik s takimi storonami ne sushestvuet!";
                }


                ResultText.Visibility = Visibility.Visible;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Vvedite korrektnie CELIE chisla!", "Oshibka vvoda", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Slishkom bolshie chisla", "Oshibka vvoda", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

