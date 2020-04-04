using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Oef_10._9
{
    class Wekker
    {
        DispatcherTimer knipper = new DispatcherTimer();
        string tijd;
        int count;
        bool color = false;
        int aantalseconden;

        public Wekker() { }

        public void setTime(string Text)
        {
            tijd = Text;
            knipper.Interval = TimeSpan.FromSeconds(1);
            knipper.Tick += knipper_tick;
        }

        private void knipper_tick(object sender, EventArgs e)
        {
            count++;
            if (color == true)
            {
                //this.Background = new SolidColorBrush(Colors.White);
                color = false;
            }
            else
            {
                //this.Background = new SolidColorBrush(Colors.HotPink);
                color = true;
                SystemSounds.Beep.Play();
            }
            if (count == aantalseconden)
            {
                knipper.Stop();
            }

        }

        public bool isTimePassed()
        {
            if (DateTime.Now.ToString("HH:mm:ss") == tijd)
            {
                knipper.Start();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void beepTime(int aantalseconden)
        {
            this.aantalseconden = aantalseconden;
        }
    }
}

