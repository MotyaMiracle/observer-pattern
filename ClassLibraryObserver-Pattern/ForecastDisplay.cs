using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double fweatherforecast;
        private double fhumidity;
        private double fpressure;
        public string Display()
        {
            return $"{fweatherforecast} - прогноз погоды, {fhumidity} - влажность, {fpressure} - давление.";
        }

        public void Update(Dictionary<string, int> intelligence)
        {
            fweatherforecast = intelligence["fweatherforecast"];
            fhumidity = intelligence["fhumidity"];
            fpressure = intelligence["fpressure"];
        }
    }
}
