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

namespace Oef_13._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persoon wesley = new Persoon("Boucher", "Wesley", "Man", "weetiknie", "04dazietgevanhier", new DateTime(1995, 5, 6));

        public MainWindow()
        {
            InitializeComponent();
            List<Persoon> personen = new List<Persoon>();

            personen.Add(wesley);

        }





    }
}
