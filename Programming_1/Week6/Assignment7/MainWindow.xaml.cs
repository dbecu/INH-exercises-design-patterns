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

namespace Assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((bool)C2K.IsChecked)
                Converted.Content = (Celsius2Kelvin(double.Parse(Number.Text)).ToString("0.00"));

            if ((bool)C2F.IsChecked)
                Converted.Content = (Celsius2Fahrenheit(double.Parse(Number.Text)).ToString("0.00"));
            
            if ((bool)F2C.IsChecked)
                Converted.Content = (Fahrenheit2Celsius(double.Parse(Number.Text)).ToString("0.00"));
        }

        double Celsius2Kelvin(double input)
        {
            return input + 273;
        }

        double Celsius2Fahrenheit(double input)
        {
            return input * 9 / 5 + 32;
        }

        double Fahrenheit2Celsius(double input)
        {
            return (input - 32) * 5 / 9;
        }
    }
}
