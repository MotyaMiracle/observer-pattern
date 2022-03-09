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
            WeatherData weatherData = new WeatherData();

            List<IDisplayElement> displays = new List<IDisplayElement>() {
                new CurrentConditionsDisplay(),
                new ForecastDisplay(),
                new StatisticsDisplay()
            };

            weatherData.RegisterObserver((CurrentConditionsDisplay)displays[0]);
            weatherData.RegisterObserver((ForecastDisplay)displays[1]);
            weatherData.RegisterObserver((StatisticsDisplay)displays[2]);

            foreach (IDisplayElement observer in displays)
                Console.WriteLine(observer.Display());

            weatherData.NotifyObserver();

            foreach (IDisplayElement observer in displays)
            {
                Console.WriteLine(observer.Display());
            }
            weatherData.RemoveObserver((ForecastDisplay)displays[1]);
            weatherData["maxtemperature"] = 666;
            foreach (IDisplayElement observer in displays)
            {
                Console.WriteLine(observer.Display());
            }
            Console.ReadKey();
        }
    }
}
