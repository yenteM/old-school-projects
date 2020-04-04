using Oef_11._7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace oef_11._7
{
    class KnipperWekker : Wekker
    {
        bool beep = true;
        Label label;

        public KnipperWekker(Label label)
        {
            this.label = label;
        }

        public override void GoOff()
        {
            base.GoOff();

            if (beep == true)
            {
                beep = false;
                label.Background = new SolidColorBrush(Colors.YellowGreen);
            }
            else
            {
                beep = true;
                label.Background = new SolidColorBrush(Colors.White);
            }
        }

    }
}
