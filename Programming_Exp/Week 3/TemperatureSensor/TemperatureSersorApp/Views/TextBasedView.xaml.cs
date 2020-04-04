using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TemperatureSersorApp.Views
{
    /// <summary>
    /// Interaction logic for TextBasedView.xaml
    /// </summary>
    public partial class TextBasedView : UserControl
    {
        private BackgroundWorker myBackgroundWorker;
        private readonly Random rand;
        private double temp;
        private Timer timer;

        public TextBasedView()
        {
            InitializeComponent();
            rand = new Random();

            myBackgroundWorker = new BackgroundWorker();
            myBackgroundWorker.WorkerSupportsCancellation = true;
            myBackgroundWorker.WorkerReportsProgress = true;
            myBackgroundWorker.DoWork += MyBackgroundWorker_DoWork;
            myBackgroundWorker.ProgressChanged += MyBackgroundWorker_ProgressChanged;
            myBackgroundWorker.RunWorkerCompleted += MyBackgroundWorker_RunWorkerCompleted;

            myBackgroundWorker.RunWorkerAsync();
        }

        private void MyBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // called on the gui thread thanks to the BackgroundWorker

        }

        private void MyBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // called on the gui thread thanks to the BackgroundWorker
            temperatureLabel.Content = e.ProgressPercentage;
            Mediator.GetInstance().OnJobChanged(this, e.ProgressPercentage);
            if (e.ProgressPercentage < 10)
            {
                temperatureLabel.Background = new SolidColorBrush(Colors.CornflowerBlue);
            }
            else if (e.ProgressPercentage > 10 && e.ProgressPercentage < 25)
            {
                temperatureLabel.Background = new SolidColorBrush(Colors.Orange);

            }
            else
            {
                temperatureLabel.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void MyBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Not on a UI thread
            e.Result = generateTemp(sender as BackgroundWorker, e);
        }

        public double generateTemp(BackgroundWorker instance, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);

                Double temp = Math.Round(rand.NextDouble() * 40, 1);
                instance.ReportProgress(Convert.ToInt32(temp));
            }

            return temp;
        }
    }
}
