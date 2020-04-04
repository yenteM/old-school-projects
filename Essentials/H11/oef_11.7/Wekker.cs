using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;

namespace Oef_11._7
{
    abstract class Wekker
    {

        string tijd;
        int aantalseconden;
        bool color = false;
        DispatcherTimer knipper = new DispatcherTimer();
        int count;
        bool beep = false;


        public Wekker(){}

        public virtual void setTime(string Text)
        {
            tijd = Text;
            knipper.Interval = TimeSpan.FromSeconds(1);
            knipper.Tick += knipper_tick;
        }

        public void knipper_tick(object sender, EventArgs e)
        {
            GoOff();
            count++;
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

        public virtual void GoOff(){}


    }


}
