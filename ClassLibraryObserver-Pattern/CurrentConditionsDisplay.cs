using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double ctemperature;
        private double chumidity;
        private double cpressure;
        public string Display()
        {
            return "Погода сйчас: " + ctemperature + "C - температура; " + chumidity + " - влажность.";
        }
        public void Update(Dictionary<string, int> intelligence)
        {
            ctemperature = intelligence["ctemperature"];
            chumidity = intelligence["chumidity"];
            cpressure = intelligence["cpressure"];
        }
    }
}
