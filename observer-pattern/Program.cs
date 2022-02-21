using System;
using ClassLibraryObserver_Pattern;
using ClassLibraryObserver_Pattern.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData subject = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(subject);
            subject.RegisterObserver(currentDisplay);
            subject.SetMeasurements(80, 65, 30.4);
            subject.SetMeasurements(82, 70, 29.2);
            subject.SetMeasurements(78, 90, 29.2);

            //subject.RegisterObserver(observer1);
            //subject.SetState("Sunny");

   
            //Console.WriteLine("Разрыв...");

            //subject.RegisterObserver(observer2);
            //subject.SetState("Cloudy");

            //Console.WriteLine(observer1.GetCounter());
            //Console.WriteLine(observer2.GetCounter());
            //Console.WriteLine("Разрыв...");

            //subject.RemoveObserver(observer2);
            //subject.SetState("Rain with thunderstorm");

            //Console.WriteLine(observer1.GetCounter());
            //Console.WriteLine(observer2.GetCounter());
            //Console.WriteLine("Разрыв...");

            Console.ReadKey();
        }
    }
}
