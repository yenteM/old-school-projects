using System;
using System.Collections.Generic;
using System.Text;
using TemperatureSensor;
using static TemperatureSensor.TempEventArgs;

namespace LightingApp.Collectors
{
    public delegate void MaxTempSensorHandler(object sender, TempEventArgs e);

    public class MaximumTemperatureCollector
    {
        public event MaxTempSensorHandler maxTempSensor;
        private int count = 0;
        private double maxValue = 0.0;

        public virtual void GetMaxTemp(double temp)
        {
            OnGettingMaxTemp(temp);
        }

        public virtual void OnGettingMaxTemp(double temp)
        {
            MaxTempSensorHandler max = maxTempSensor as MaxTempSensorHandler;
            if (temp > maxValue)
            {
                maxValue = temp;
            }

            if (count == 10)
            {
                max?.Invoke(this, new TempEventArgs(maxValue));
            }

            count++;

        }
    }
}
