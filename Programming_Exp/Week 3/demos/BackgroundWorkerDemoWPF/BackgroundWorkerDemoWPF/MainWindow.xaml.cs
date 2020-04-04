using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BackgroundWorkerDemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker myBackgroundWorker;

        public MainWindow()
        {
            InitializeComponent();
            myBackgroundWorker = new BackgroundWorker();
            myBackgroundWorker.WorkerSupportsCancellation = true;
            myBackgroundWorker.WorkerReportsProgress = true;
            myBackgroundWorker.DoWork += MyBackgroundWorker_DoWork;
            myBackgroundWorker.ProgressChanged += MyBackgroundWorker_ProgressChanged;
            myBackgroundWorker.RunWorkerCompleted += MyBackgroundWorker_RunWorkerCompleted; 
        }

        private void MyBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // called on the gui thread thanks to the BackgroundWorker
            StartButton.IsEnabled = true;
            pbStatus.Value = 0;
            if (!e.Cancelled)
            {
                OutputLabel.Text = "BackgroundWorker Completed!";
            }
            else
            {
                OutputLabel.Text = "Cancelled!";
            }
        }

        private void MyBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // called on the gui thread thanks to the BackgroundWorker
            pbStatus.Value = e.ProgressPercentage;
        }

        private void MyBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Not on a UI thread
            e.Result = Calculate(sender as BackgroundWorker, e);
        }

        private long Calculate(BackgroundWorker instance, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (instance.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    instance.ReportProgress(i);
                }
            }
            return 0L;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            myBackgroundWorker.CancelAsync(); // Cancellation pending mode
            CancelButton.IsEnabled = false;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            CancelButton.IsEnabled = true;
            OutputLabel.Text = "";

            // fires the event which is handled by MyBackgroundWorker_DoWork
            // This executes MyBackgroundWorker_DoWork in a background thread
            myBackgroundWorker.RunWorkerAsync();
        }
    }
}
