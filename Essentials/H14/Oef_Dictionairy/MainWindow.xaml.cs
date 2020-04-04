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

namespace Oef_Dictionairy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] names = new string[20];
        private string[] numbers = new string[20];
        private Dictionary<string, Persoon> lookup = new Dictionary<string, Persoon>();

        public MainWindow()
        {
            InitializeComponent();

            names[0] = "yente";
            numbers[0] = "315315";

            names[1] = "max";
            numbers[1] = "315754";

            names[2] = "wesley";
            numbers[2] = "319841";

            names[3] = "kevin";
            numbers[3] = "315215";

            names[4] = "mike";
            numbers[4] = "386315";

            names[5] = "wietse";
            numbers[5] = "351315";

            names[6] = "END";


            Persoon persoon1 = new Persoon("yente", 315315);
            Persoon persoon2 = new Persoon("max", 315754);
            Persoon persoon3 = new Persoon("wesley", 319841);
            Persoon persoon4 = new Persoon("kevin", 315215);
            Persoon persoon5 = new Persoon("mike", 386315);
            Persoon persoon6 = new Persoon("wietse", 351315);

            lookup.Add(persoon1.Naam, persoon1);
            lookup.Add(persoon2.Naam, persoon2);
            lookup.Add(persoon3.Naam, persoon3);
            lookup.Add(persoon4.Naam, persoon4);
            lookup.Add(persoon5.Naam, persoon5);
            lookup.Add(persoon6.Naam, persoon6);


        }

        private void zoekButton_Click(object sender, RoutedEventArgs e)
        {
            string key;
            Persoon persoon;

            if (searchTextBox.Text != "")
            {
                key = searchTextBox.Text;
                if (lookup.ContainsKey(key))
                {
                    persoon = lookup[key];
                    resultLabel.Content = "nummer is " + persoon.Nummer;
                }
                else {
                        MessageBox.Show("Persoon: " + key + " niet gevonden.");
                }
            }
        }

        private void arrayZoekButton_Click(object sender, RoutedEventArgs e)
        {

            Find();

        }

        private void Find()
        {
            int index = 0;
            string wanted = searchTextBox.Text;
            while (names[index] != wanted && (names[index] != "END"))
            {
                index++;
            }
            if (names[index] == wanted)
            {
                resultLabel.Content = "Number is " + numbers[index];
            }
            else
            {
                resultLabel.Content = "Name not found";
            }
        }

    }
}
