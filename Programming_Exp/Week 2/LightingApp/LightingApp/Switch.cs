using System;
using System.Collections.Generic;
using System.Text;

namespace LightingApp
{
    public class Switch
    {
        private bool isOn = false;

        public void Flip(List<LightBulb> lightBulbs)
        {
            isOn = !isOn;

            foreach (LightBulb bulb in lightBulbs)
            {
                bulb.IsOn = this.isOn;
                Console.WriteLine(bulb.IsOn == true ? $"The lightbulb is on and has the color {bulb.Color}" : $"The lightbulb is off");
            } 
        }

    }
}
