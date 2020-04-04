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

namespace Exercise5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum = 0;
        bool plusclicked = true;
        bool startNewNumber = false;
        String buttonContent = "";

        public MainWindow()
        {
            InitializeComponent();

            zeroButton.Click += Button_Click;
            oneButton.Click += Button_Click;
            twoButton.Click += Button_Click;
            threeButton.Click += Button_Click;
            fourButton.Click += Button_Click;
            fiveButton.Click += Button_Click;
            sixButton.Click += Button_Click;
            sevenButton.Click += Button_Click;
            eigthButton.Click += Button_Click;
            nineButton.Click += Button_Click;
            plusButton.Click += Button_Click;
            equalsButton.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonClicked = button.Content.ToString();

            if (buttonClicked != "+" && buttonClicked != "=")
            {
                if (startNewNumber == true)
                {
                    resultTextBox.Text = "";
                    buttonContent = "";
                    startNewNumber = false;
                    buttonContent += button.Content.ToString();
                    resultTextBox.Text = buttonContent;
                }
                else
                {
                    buttonContent += button.Content.ToString();
                    resultTextBox.Text = buttonContent;
                }
            }

            if (plusclicked == true)
            {
                sum += Convert.ToInt32(buttonContent);
                plusclicked = false;
            }

            if (buttonClicked == "+")
            {
                plusclicked = true;
                startNewNumber = true;
            }

            if (buttonClicked == "=")
            {
                resultTextBox.Text = Convert.ToString(sum);
            }




        }
    }
}
