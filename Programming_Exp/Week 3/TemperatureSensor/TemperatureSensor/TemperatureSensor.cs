using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LightingApp.Collectors;
using static TemperatureSensor.TempEventArgs;

namespace TemperatureSensor
{
    class TemperatureSensor
    {
        //private static Random rand = new Random();
        //private static Timer timer;
        //public static MinimumTemperatureCollector minimum = new MinimumTemperatureCollector();
        //public static MaximumTemperatureCollector maximum = new MaximumTemperatureCollector();
        //public static AverageTemperatureCollector average = new AverageTemperatureCollector();
        //public static TresholdTemperatureCollector high = new TresholdTemperatureCollector();

        //public static void Main(string[] args)
        //{
        //    minimum.minTempSensor += Temp_GetMinTemp;
        //    maximum.maxTempSensor += Temp_GetMaxTemp;
        //    average.averageTempSensor += Temp_GetAverageTemp;
        //    high.HighTempSensor += Temp_HighTemp;


        //    var timerState = new TimerState { Counter = 0 };

        //    timer = new Timer(
        //        callback: new TimerCallback(TimerTask),
        //        state: timerState,
        //        dueTime: 1000,
        //        period: 100);

        //    while (timerState.Counter <= 10)
        //    {
        //        Task.Delay(1000).Wait();
        //    }

        //    timer.Dispose();
        //    Console.ReadLine();
        //}

        //static void Temp_GetMinTemp(object sender, TempEventArgs e)
        //{
        //    Console.WriteLine($"the min temp is: {e.Temp}");
        //}

        //static void Temp_GetMaxTemp(object sender, TempEventArgs e)
        //{
        //    Console.WriteLine($"the max temp is: {e.Temp}");
        //}

        //static void Temp_GetAverageTemp(object sender, TempEventArgs e)
        //{
        //    Console.WriteLine($"the average temp is: {e.Temp}\n");
        //}

        //static void Temp_HighTemp(object sender, TempEventArgs e)
        //{
        //    Console.WriteLine("HOTHOTHOT!!!!!!!");
        //}

        //private static void TimerTask(object timerState)
        //{
        //    double temp = Math.Round(rand.NextDouble() * 40, 1);

        //    Console.WriteLine($"Current temperature: {temp}");

        //    high.AlertWithHighTemp(temp);
        //    average.GetAverageTemp(temp);
        //    minimum.GetMinTemp(temp);
        //    maximum.GetMaxTemp(temp);

        //    var state = timerState as TimerState;
        //    Interlocked.Increment(ref state.Counter);
        //}

        //class TimerState
        //{
        //    public int Counter;
        //}
    }
}
