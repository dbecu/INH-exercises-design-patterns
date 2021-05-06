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
        private string afterLocal;
        private int[] beforeArray;

        public MainWindow()
        {
            InitializeComponent();

            Loaded += MyWindow_Loaded;
            
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Random rand = new Random();

            string beforeEnd = "";

            int[] before = new int[20];

            for (int i = 0; i < 20; i++)
            {
                before[i] = rand.Next(0, 500);
                beforeEnd += "Element " + i.ToString("00") + " = " + before[i] + "\n";
            }

            beforeArray = before;
            Before.Content = beforeEnd;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string afterEnd = "";

            int[] after = new int[20];
            int compare = int.Parse(CompareNumber.Text);

            for (int i = 0; i < 20; i++)
            {
                if (beforeArray[i] >= compare)
                    after[i] = beforeArray[i] + 10;
                else
                    after[i] = beforeArray[i] - 5;

                afterEnd += "Element " + i.ToString("00") + " = " + after[i] + "\n";
            }

            After.Content = afterEnd;
            CompareButton.IsEnabled = false;

        }
    }
}
