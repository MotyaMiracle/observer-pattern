using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class ConcreteObserver : IObserver
    {
        private int Counter;
        public void Update()
        {
            Counter += 1;

        }
        public int GetCounter()
        {
            return Counter;
        }
    }
}
