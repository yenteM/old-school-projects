using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Voetbal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int spelersCount = 11;
        private List<string> allePloegen = new List<string>();
        private List<string> alleSpelers = new List<string>();
        private string[] ploegenArray;
        private string[] spelerArray;
        private List<Ploeg> ploegenList = new List<Ploeg>();
        private List<Speler> spelersList = new List<Speler>();
        private List<Ploeg> ploegenreeks1 = new List<Ploeg>();
        private List<Ploeg> ploegenreeks2 = new List<Ploeg>();
        private List<string> speeldag1 = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DraaiPloegen()
        {
            Ploeg hulp = ploegenreeks1[1];

            for (int i = 1; i < 7; i++)
            {
                ploegenreeks1[i] = ploegenreeks1[i + 1];
            }

            ploegenreeks1[7] = ploegenreeks2[7];

            for (int i = 7; i > 0; i--)
            {
                ploegenreeks2[i] = ploegenreeks2[i - 1];
            }

            ploegenreeks2[0] = hulp;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            StreamReader inputPloegenStream = new StreamReader("Ploegen.txt", System.Text.Encoding.Default);
            StreamReader inputSpelersStream = new StreamReader("Spelers.txt", System.Text.Encoding.Default);
            try
            {
                int i = 0;
                string ploeg;
                while ((ploeg = inputPloegenStream.ReadLine()) != null)
                {
                    allePloegen.Add(ploeg);
                    i++;
                }

                i = 0;
                string speler;
                while ((speler = inputSpelersStream.ReadLine()) != null)
                {
                    alleSpelers.Add(speler);
                    i++;
                }

                inputPloegenStream.Close();
                inputSpelersStream.Close();
                MaakPloegen(allePloegen, alleSpelers);
                competitieMenuItem.IsEnabled = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("het bestand is niet gevonden" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorry er liep iets fout, als dit probleem zich blijft voordoen kan u de programmeur contacteren via email ... " + ex);
            }

        }

        private void MaakPloegen(List<string> ploegen, List<string> spelers)
        {
            int count = 0;
            spelersList.Clear();
            ploegenList.Clear();

            for (int ploeg = 0; ploeg < ploegen.Count; ploeg++)
            {

                for (int i = count; i < spelersCount * (ploeg + 1); i++)
                {
                    spelerArray = spelers[i].Split(',');
                    spelersList.Add(new Speler(spelerArray[3], spelerArray[2], Convert.ToInt32(spelerArray[1]), (SpelersFunctie)Convert.ToChar(spelerArray[4])));
                    count++;
                }

                ploegenArray = ploegen[ploeg].Split(',');
                ploegenList.Add(new Ploeg(Convert.ToInt32(ploegenArray[0]), ploegenArray[1], 0, spelersList));
                spelersList.Clear();
            }


        }

        private void Samenstellen_Wedstrijden_Click(object sender, RoutedEventArgs e)
        {
            SamenstellenWedstrijden();


            samenstellenMenuItem.IsEnabled = false;
            ingeven_scoresMenuItem.IsEnabled = true;
            rangschikkingMenuItem.IsEnabled = true;
        }

        private void SpeelDagen()
        {
            DateTime day = new DateTime(DateTime.Now.Year, 7, 31);
            while (day.DayOfWeek != DayOfWeek.Saturday)
            {
                day = day.AddDays(-1);
            }


            for (int i = 0; i < 15; i++)
            {
                speelDagenListBox.Items.Add("dag " + (i + 1) + ": " + new DateTime(2017, day.Month, day.Day).ToString("dd/MM/yyyy"));
                day = day.AddDays(7);
            }
        }

        private void ingeven_scoresMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SpeelDagen();

            for (int i = 0; i < 8; i++)
            {
                speeldag1.Add(ploegenreeks1[i].Naam() + " - " + ploegenreeks2[i].Naam());
            }
        }

        private void speelDagenListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int dag = speelDagenListBox.SelectedIndex;

            
            MaakPloegen(allePloegen, alleSpelers);
            SamenstellenWedstrijden();
            wedstrijdenListBox.Items.Clear();

            if (dag != 0)
            {
                for (int i = 0; i < dag; i++)
                {
                    DraaiPloegen();
                }
            }


            for (int i = 0; i < 8; i++)
            {
                wedstrijdenListBox.Items.Add(ploegenreeks1[i].Naam() + " - " + ploegenreeks2[i].Naam());
            }

        }

        private void SamenstellenWedstrijden()
        {
            ploegenreeks1.Clear();
            ploegenreeks2.Clear();

            for (int i = 0; i < 8; i++)
            {
                ploegenreeks1.Add(ploegenList[i]);
            }

            for (int i = 8; i <= 15; i++)
            {
                ploegenreeks2.Add(ploegenList[i]);
            }

        }

    }
}
