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

namespace Oef_14._20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int aantal = 1000000;
        private List<Vak> vakList;
        private Dictionary<string, Vak> vakDictionairy;
        private Vak[] vakArray;

        public MainWindow()
        {
            InitializeComponent();

            MaakVakList(aantal);
            MaakVakDictionairy(aantal);
            MaakVakArray(aantal);

        }

        private void MaakVakList(int size)
        {
            List<Vak> vakList = new List<Vak>();

            for (int i = 0; i < size; i++)
            {
                Vak vak = new Vak("vak" + i, "docent", 6);
                vakList.Add(vak);
            }
        }

        private void MaakVakDictionairy(int size)
        {
            vakDictionairy = new Dictionary<string, Vak>();

            for (int i = 0; i < size; i++)
            {
                Vak vak = new Vak("vak" + i, "docent", 6);
                vakDictionairy.Add(vak.Naam, vak);
            }
        }

        private void MaakVakArray(int size)
        {
            vakArray = new Vak[size];

            for (int i = 0; i < size; i++)
            {
                vakArray[i] = new Vak("vak" + i, "docent", 6);
            }
        }

        private void ZoekInList(string zoek)
        {
            for (int i = 0; i < aantal; i++)
            {
                if (vakList[i].Naam == zoek)
                {
                    resultTextBlock.Text = "Vakgegevens voor " + vakList[i].Naam + Environment.NewLine + Environment.NewLine +
                        "Docent: " + vakList[i].Docent + Environment.NewLine + "Uren: " + vakList[i].Uren;
                }
                else
                {
                    MessageBox.Show("niet gevonden");
                }
            }
        }

        private void ZoekInDictionairy(string zoek)
        {
            for (int i = 0; i < aantal; i++)
            {
                if (vakDictionairy.ContainsKey(zoek))
                {

                }
                else
                {
                    MessageBox.Show("niet gevonden");
                }
            }
        }

        private void ZoekInArray(string zoek)
        {
            for (int i = 0; i < aantal; i++)
            {
                if (vakArray[i].Naam == zoek)
                {
                    resultTextBlock.Text = "Vakgegevens voor " + vakArray[i].Naam + Environment.NewLine + Environment.NewLine + 
                        "Docent: " + vakArray[i].Docent + Environment.NewLine + "Uren: " + vakArray[i].Uren;
                }
                else
                {
                    MessageBox.Show("niet gevonden");
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ZoekInList("vak999999");
        }
    }
}
