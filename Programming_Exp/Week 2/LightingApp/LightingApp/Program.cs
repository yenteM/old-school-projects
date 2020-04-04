using System;
using System.Collections.Generic;

namespace LightingApp
{
    class Program
    {
        public delegate void TurnOn(List<LightBulb> lights);

        

        static void Main(string[] args)
        {
            LightBulb bulb1 = new LightBulb
            {
                Color = "Blue"
            };
            LightBulb bulb2 = new LightBulb
            {
                Color = "Red"
            };
            List<LightBulb> lights = new List<LightBulb>();
            lights.Add(bulb1);
            lights.Add(bulb2);

            Switch _switch = new Switch();
            //Switch _switch2 = new Switch();
            TurnOn turnOn = (l) =>
            {
                _switch.Flip(l);
            };

            turnOn(lights);

            //turnOn = _switch2.Flip;

            turnOn(lights);
            turnOn(lights);
            turnOn(lights);
            turnOn(lights);

            //turnOn = _switch.Flip;

            //turnOn();

            //turnOn = _switch2.Flip;

            //turnOn();

            //turnOn = _switch.Flip;

            //turnOn();

            Console.Read();
        }
    }
}
