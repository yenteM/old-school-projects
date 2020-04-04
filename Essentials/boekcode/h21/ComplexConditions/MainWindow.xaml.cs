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

namespace ComplexConditions
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

        private void Foo1()
        {
            const int maxSize = 100;
            int[] table = new int[maxSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);
            int index = 0;
            while ((index < maxSize) && (table[index] != wanted))
            {
                index++;
            }

            if (table[index] == wanted)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void Foo2()
        {
            const int maxSize = 100;
            int[] table = new int[maxSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);

            const int stillSearching = 0;
            const int found = 1;
            const int notFound = 2;
            int state = stillSearching;

            int index = 0;
            while (state == stillSearching)
            {
                if (table[index] == wanted)
                {
                    state = found;
                }
                else if (index + 1 == maxSize)
                {
                    state = notFound;
                }
                index++;
            }

            if (state == found)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void ifs1()
        {
            int a = 0, b = 0, c = 0;
            int largest;

            if (a > b)
            {
                if (a > c)
                {
                    largest = a;
                }
                else
                {
                    largest = c;
                }
            }
            else
            {
                if (b > c)
                {
                    largest = b;
                }
                else
                {
                    largest = c;
                }
            }
        }

        private void ifs2()
        {
            int a = 0, b = 0, c = 0;
            int largest;

            if ((a >= b) && (a >= c))
            {
                largest = a;
            }
            else if ((b >= a) && (b >= c))
            {
                largest = b;
            }
            else
            {
                largest = c;
            }
        }
    }
}
