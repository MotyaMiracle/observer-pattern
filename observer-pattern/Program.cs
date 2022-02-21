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
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            ConcreteSubject subject = new ConcreteSubject();

            subject.RegisterObserver(observer1);
            subject.SetState("Sunny");

            Console.WriteLine(observer1.GetCounter());
            Console.WriteLine(observer2.GetCounter());
            Console.WriteLine("Разрыв...");

            subject.RegisterObserver(observer2);
            subject.SetState("Cloudy");

            Console.WriteLine(observer1.GetCounter());
            Console.WriteLine(observer2.GetCounter());
            Console.WriteLine("Разрыв...");

            subject.RemoveObserver(observer2);
            subject.SetState("Rain with thunderstorm");

            Console.WriteLine(observer1.GetCounter());
            Console.WriteLine(observer2.GetCounter());
            Console.WriteLine("Разрыв...");

            Console.ReadKey();
        }
    }
}
