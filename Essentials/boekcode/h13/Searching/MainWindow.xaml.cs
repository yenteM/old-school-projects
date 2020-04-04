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

namespace Searching
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

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            int length = shoppingListBox.Items.Count;
            int index = 0;
            bool found = false;
            string itemWanted = findTextBox.Text;
            ListBoxItem item;

            while ((!found) && (index < length))
            {
                item = (ListBoxItem)shoppingListBox.Items[index];
                if (Convert.ToString(item.Content) == itemWanted)
                {
                    found = true;
                    resultLabel.Content = "Item found, index: " + index;
                }
                else
                {
                    index++;
                }
            }
        }

        // KH: werkt niet, want je zoekt naar string in lijst en niet
        // KH: naar ListBoxItem met string in
        //private void findButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string itemWanted = findTextBox.Text;
        //    if (shoppingListBox.Items.Contains(itemWanted))
        //    {
        //        resultLabel.Content = "Item found, index: " +
        //            shoppingListBox.Items.IndexOf(itemWanted);
        //    }
        //}

        // KH: werkt ook niet want
        // KH: itemWanted is een nieuw item met een te zoeken
        // KH: string en zal dus niet in de lijst gevonden worden
        //private void findButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ListBoxItem itemWanted = new ListBoxItem();
        //    itemWanted.Content = findTextBox.Text;
        //    if (shoppingListBox.Items.Contains(itemWanted))
        //    {
        //        resultLabel.Content = "Item found, index: " +
        //            shoppingListBox.Items.IndexOf(itemWanted);
        //    }
        //}
    }
}
