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

namespace AsyncGoodWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private delegate void ShowProgressDelegate(int val);
        private delegate void StartProcessDelegate(int val);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //Call long running process
            StartProcessDelegate startDel = new StartProcessDelegate(StartProcess);
            //startDel.BeginInvoke executes delegate on new thread
            startDel.BeginInvoke(100, null, null);

            //Show message box to demonstrate that StartProcess()
            //is running asynchronously
            MessageBox.Show("Called after async process started.");
        }

        // Called Asynchronously
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);
            }
        }

        private void ShowProgress(int i)
        {
            //On helper thread so invoke on UI thread to avoid 
            //updating UI controls from alternate thread			
            if (!Dispatcher.CheckAccess())
            {
                ShowProgressDelegate del = new ShowProgressDelegate(ShowProgress);
                //this.BeginInvoke executes delegate on thread used by form (UI thread)
                Dispatcher.BeginInvoke(del, new object[] { i });
            }
            else
            { //On UI thread so we are safe to update
                this.lblOutput.Text = i.ToString();
                this.pbStatus.Value = i;
            }
        }
    }
}
