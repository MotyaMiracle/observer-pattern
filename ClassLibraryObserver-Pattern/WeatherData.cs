using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class WeatherData : ISubject
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private List<IObserver> observers = new List<IObserver>(); 
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach ( IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        public double GetTemperature()
        {
            return temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetPressure()
        {
            return pressure;
        }
    }
}
