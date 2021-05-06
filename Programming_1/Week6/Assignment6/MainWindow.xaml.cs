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

namespace Assignment6
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

        public void SquareByReference(ref int number)
        {
            number =  number * number;
        }
        public void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }
        public int SquareByValue(int number)
        {
            return number * number;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(Number.Text);
            SquareByReference(ref input);

            Result.Content = input;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SquareByReferenceOut(int.Parse(Number.Text), out int i);

            Result.Content = i;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Result.Content = SquareByValue(int.Parse(Number.Text));
        }
    }
}
