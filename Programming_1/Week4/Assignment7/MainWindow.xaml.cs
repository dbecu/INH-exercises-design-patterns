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
            
            int sides = int.Parse(SideNumber.Text);
            string block = "";

            for(int i = 0; i < sides; i++)
            {

                for (int k = 0; k < sides; k++)
                {

                    if (i == 0 || i == sides - 1)
                        block += "X";

                        
                    else if (k == 0 || k == sides - 1)
                        block += "X";
                        
                    else
                        block += " ";

                }

                block += "\n";
            }
            

            Square.Content = block;

            
        }
    }
}
