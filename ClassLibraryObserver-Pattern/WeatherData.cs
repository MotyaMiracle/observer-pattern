using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class WeatherData : ISubject
    {
        public WeatherData()
        {
            Random random = new Random();
            foreach (string key in var) keys.Add(key, random.Next(1, 100));
        }
        private List<IObserver> observers = new List<IObserver>();
        private Dictionary<string, int> keys = new Dictionary<string, int>();
        private List<string> var = new List<string>() {"temperature","humidity","pressure","mintemperature",
            "middletemperature","maxtemperature","shumidity","spressure","fweatherforecast","fhumidity","fpressure",
            "ctemperature","chumidity","cpressure"};
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.RemoveAt(observers.IndexOf(observer));
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers) observer.Update(keys);
        }
        public int this[string var]
        {
            set
            {
                keys[var] = value;
                this.NotifyObserver();
            }
        }
    }
}
