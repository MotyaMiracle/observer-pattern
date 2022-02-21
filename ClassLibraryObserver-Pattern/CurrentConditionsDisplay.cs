using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject WeatherData)
        {
            this.WeatherData = WeatherData;
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "C degrees and " + humidity + "% humidity");
        }
    }
}
