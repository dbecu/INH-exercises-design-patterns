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

namespace Assignment5
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


        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = addition(double.Parse(NumberOne.Text), double.Parse(NumberTwo.Text)).ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = subtraction(double.Parse(NumberOne.Text), double.Parse(NumberTwo.Text)).ToString();
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = multiply(double.Parse(NumberOne.Text), double.Parse(NumberTwo.Text)).ToString();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = division(double.Parse(NumberOne.Text), double.Parse(NumberTwo.Text)).ToString("0.000");

        }

        public static double addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double division(double num1, double num2)
        {
            return num1 / num2;
        }
    }

}
