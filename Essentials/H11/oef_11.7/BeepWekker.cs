using Oef_11._7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace oef_11._7
{
    class BeepWekker : Wekker
    {
        bool beep;


        public override void GoOff()
        {
            base.GoOff();

            if (beep == true)
            {
                beep = false;
            }
            else
            {
                beep = true;
                SystemSounds.Beep.Play();
            } 
        }

    }
}
