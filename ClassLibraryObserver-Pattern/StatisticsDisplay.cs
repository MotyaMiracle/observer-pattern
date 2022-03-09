using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double mintemperature;
        private double middletemperature;
        private double maxtemperature;
        private double shumidity;
        private double spressure;
        public string Display()
        {
            return $"{maxtemperature}  - максимальная температура, {mintemperature} - минимальная температура, " +
                $"{middletemperature} - средняя температура, {shumidity} - влажность и {spressure} - давление.";
        }

        public void Update(Dictionary<string, int> intelligence)
        {
            mintemperature = intelligence["mintemperature"];
            middletemperature = intelligence["middletemperature"];
            maxtemperature = intelligence["maxtemperature"];
            shumidity = intelligence["shumidity"];
            spressure = intelligence["spressure"];
        }
    }
}
