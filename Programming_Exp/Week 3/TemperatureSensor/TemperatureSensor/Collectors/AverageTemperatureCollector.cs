using System;
using System.Collections.Generic;
using System.Text;
using TemperatureSensor;

namespace LightingApp.Collectors
{
    public delegate void AverageTempSensorHandler(object sender, TempEventArgs e);

    class AverageTemperatureCollector
    {
        public event AverageTempSensorHandler averageTempSensor;
        private double count = 1;
        private double totalValue = 0.0;
        private double averageValue = 0;
        
        public virtual void GetAverageTemp(double temp)
        {
            OnGettingAverageTemp(temp);
        }

        public void OnGettingAverageTemp(double value)
        {
            AverageTempSensorHandler average = averageTempSensor as AverageTempSensorHandler;

            totalValue += value;
            averageValue = totalValue/count;

            average?.Invoke(this, new TempEventArgs(Math.Round(averageValue,1)));
            count++;
        }

    }
}
