using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver_Pattern.Interfaces
{
    public class ConcreteSubject : ISubject
    {
        private string weather;
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
                observer.Update();
            }

        }
        public string GetState()
        {
            return weather;
        }
        public void SetState(string weather)
        {
            this.weather = weather;
            NotifyObserver();
        }
    }
}
