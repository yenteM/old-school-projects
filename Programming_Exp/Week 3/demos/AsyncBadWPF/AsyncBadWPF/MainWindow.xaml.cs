using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncBadWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void UpdateProgressDelegate(int val);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var progDel = new UpdateProgressDelegate(StartProcess);
            // call this asynchronous: spin in another thread
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done with operation!");
        }

        // Called Asynchronously
        // This BAD because the helper thread is updating UI components directly
        private void StartProcess(int max)
        {
            this.pbStatus.Maximum = max;
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(10);
                lblOutput.Text = i.ToString();
                this.pbStatus.Value = i;
            }
        }
    }
}
