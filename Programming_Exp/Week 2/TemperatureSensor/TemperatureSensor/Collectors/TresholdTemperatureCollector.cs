using System;
using System.Collections.Generic;
using System.Text;
using TemperatureSensor;

namespace LightingApp.Collectors
{
    public delegate void HighTempSensorHandler(object sender, TempEventArgs e);

    class TresholdTemperatureCollector
    {
        public event HighTempSensorHandler HighTempSensor;

        public void AlertWithHighTemp(double temp)
        {
            HighTempSensorHandler high = HighTempSensor as HighTempSensorHandler;

            if (temp > 35.0)
            {
                high?.Invoke(this, new TempEventArgs(temp));
            }
        }

    }
}
