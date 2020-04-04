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

namespace Exercise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person();
        public MainWindow()
        {
            InitializeComponent();
            person.FirstName = "<Enter first name>";
            person.LastName = "<Enter last name>";
            person.FullName = "";
            DataContext = person;
        }

        #region Placeholders
        private void SetText(TextBox textbox, string text)
        {
            textbox.Text = text;
        }

        private void FirstNamePlaceholder(object sender, RoutedEventArgs e)
        {
            if (firstNameTextBox.Text == "")
                SetText(firstNameTextBox, "<Enter first name>");
        }

        private void FirstNameDeletePlaceholder(object sender, RoutedEventArgs e)
        {
            if (firstNameTextBox.Text.Equals("<Enter first name>"))
                SetText(firstNameTextBox, "");
        }

        private void LastNamePlaceholder(object sender, RoutedEventArgs e)
        {
            if (lastNameTextBox.Text == "")
                SetText(lastNameTextBox, "<Enter last name>");
        }

        private void LastNameDeletePlaceholder(object sender, RoutedEventArgs e)
        {
            if (lastNameTextBox.Text == "<Enter last name>")
                SetText(lastNameTextBox, "");
        }

        private void FullNamePlaceholder(object sender, RoutedEventArgs e)
        {
            if (fullNameTextBox.Text == "")
                SetText(fullNameTextBox, "<Enter first name> <Enter last name>");
        }

        private void FullNameDeletePlaceholder(object sender, RoutedEventArgs e)
        {
            if (fullNameTextBox.Text == "<Enter first name> <Enter last name>")
                SetText(fullNameTextBox, "");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
