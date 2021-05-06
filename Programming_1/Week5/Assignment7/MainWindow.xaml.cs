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
            int[] dice = new int[6];

            Random rand = new Random();

            int value = -1;

            for (int i = 0; i < 6000; i++)
            {

                value = rand.Next(1, 7);

                switch (value)
                {
                    case 1:
                        dice[0]++;
                        break;

                    case 2:
                        dice[1]++;
                        break;

                    case 3:
                        dice[2]++;
                        break;

                    case 4:
                        dice[3]++;
                        break;

                    case 5:
                        dice[4]++;
                        break;

                    case 6:
                        dice[5]++;
                        break;

                    default:
                        Console.WriteLine("Error: random number out of bounds.");
                        break;
                }                
            }

            string total = "";

            for (int i = 0; i < 6; i++)       
                total += "Number of throw of value " + (i + 1) + " = " + dice[i] + "\n";

            Label.Content = total;
        }
    }
}
