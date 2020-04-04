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

namespace Exercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentenList = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            studentenList.Add(new Student("yente", "martens", "boomstraat", "Borgloon", "Limburg", 3840, "012/741469", "0493/717927"));
            studentenList.Add(new Student("yente", "martens1", "boomstraat", "Antwerpen", "Antwerpen", 3500, "021/314169", "0493/717927"));
            studentenList.Add(new Student("yente", "martens2", "boomstraat", "Brussel", "Zaventem", 3700, "012/7429151", "0493/717927"));

            studentenListBox.ItemsSource = studentenList;
            studentenListBox.SelectedItem = 0;
            mainGrid.DataContext = studentenList[0];
            studentenListBox.SelectionChanged += StudentenListBox_SelectionChanged;
            StateComboBox.DataContext = studentenList[0];

        }

        private void StudentenListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainGrid.DataContext = null;
            mainGrid.DataContext = studentenList[studentenListBox.SelectedIndex];
            StateComboBox.DataContext = null;
            StateComboBox.DataContext = studentenList[studentenListBox.SelectedIndex];
        }
    }
}
