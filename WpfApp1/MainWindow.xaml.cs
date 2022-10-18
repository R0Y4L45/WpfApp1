using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MouseButtonEventArgs = System.Windows.Input.MouseButtonEventArgs;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        byte r, g, b;
        bool flag = false;
        public MainWindow() => InitializeComponent();



        private void btn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Button? btn = sender as Button;


            var random = new Random();

            r = Convert.ToByte(random.Next(0, 255));
            g = Convert.ToByte(random.Next(0, 255));
            b = Convert.ToByte(random.Next(0, 255));

            btn!.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

            MessageBox.Show(@$"Red : {r}, Green : {g}, Blue : {b}
Bide bu button basqadi ee ;-)", "Melumat verirux", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button? btn = sender as Button;
            if (!flag)
            {
                Title = Title + " " + btn?.Content;
                flag = true;
            }
            else
                Title = Title + ", " + btn?.Content;
            grid.Children.Remove(btn);

        }

        private void btn1_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Button? btn = sender as Button;

            if (btn!.IsMouseOver)
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            }
        }

    }
}
