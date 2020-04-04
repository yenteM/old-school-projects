using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace oef1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> states = new List<string>();
        List<Person> persons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            States();
            Persons();

            studentsListBox.ItemsSource = persons;
          
            
        }

        private void States()
        {
            states.Add("Limburg");
            states.Add("Antwerpen");
            states.Add("Brussel");
            states.Add("West-Vlaanderen");
            states.Add("Oost-Vlaanderen");
            states.Add("Vlaams-Brabant");
            states.Add("Waals-Brabant");
            states.Add("Henegouwen");
            states.Add("Luik");
            states.Add("Namen");
            states.Add("Luxemburg");

            foreach (string state in states)
            {
                stateComboBox.Items.Add(state);
            }

        }
        private void Persons()
        {
            persons.Add(new Person
            {
                Name = "Erik Ulrichts",
                Street = "ElfdeLinie 11",
                City = "Hasselt",
                State = states.IndexOf("Limburg"),
                Zip = 3630,
                Phone = "4555",
                Cell = "555"
            });

            persons.Add(new Person
            {
                Name = "Arne Motmans",
                Street = "Baasstraat 69",
                City = "Sint-Truiden",
                State = states.IndexOf("Limburg"),
                Zip = 3800,
                Phone = "6969",
                Cell = "666"
            });

            persons.Add(new Person
            {
                Name = "Pieter DeSchieter",
                Street = "Boerengat 0",
                City = "Luik",
                State = states.IndexOf("Luik"),
                Zip = 2830,
                Phone = "0000",
                Cell = "000"
            });
        }

        private void studentsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = studentsListBox.SelectedItem;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            persons.Add(new Person
            {
                Name = "test"
            });
        }
    }
}
