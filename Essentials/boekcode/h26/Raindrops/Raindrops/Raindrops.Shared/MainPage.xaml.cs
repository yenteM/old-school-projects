using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Raindrops
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Random randomNumber = new Random();
        private double x, y, size;
        private SolidColorBrush brush;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            gapTextBlock.Text = String.Format("{0} ms gap", gapSlider.Value);
            brush = new SolidColorBrush(Colors.Blue);
            timer.Interval = TimeSpan.FromMilliseconds(gapSlider.Value);
            timer.Tick += timer_Tick;

            gapSlider.ValueChanged += gapSlider_ValueChange;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
        }

        private void timer_Tick(object sender, object e)
        {
            x = randomNumber.Next(0, Convert.ToInt32(paperCanvas.ActualWidth));
            y = randomNumber.Next(0, Convert.ToInt32(paperCanvas.ActualHeight));
            size = randomNumber.Next(1, 40);

            Ellipse ellipse = new Ellipse();
            ellipse.Width = size;
            ellipse.Height = size;
            ellipse.Stroke = brush;
            ellipse.Fill = brush;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            paperCanvas.Children.Add(ellipse);

            // set new interval for timer
            timer.Stop();
            int ms = randomNumber.Next(1, Convert.ToInt32(gapSlider.Value));
            timer.Interval = TimeSpan.FromMilliseconds(ms);
            timer.Start();
        }

        private void gapSlider_ValueChange(object sender, RangeBaseValueChangedEventArgs e)
        {
            int timeGap = Convert.ToInt32(gapSlider.Value);
            gapTextBlock.Text = String.Format("{0} ms gap", timeGap);
        }

    }
}

