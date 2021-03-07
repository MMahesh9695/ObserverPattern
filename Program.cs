using ObservablePattern.Observable;
using ObservablePattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            concreteObservable obj = new concreteObservable();
            ConcreteObserver1 observer1 = new ConcreteObserver1();
            ConcreteObserver2 observer2 = new ConcreteObserver2();
            obj.register(observer1);
            obj.register(observer2);
            obj.getChanged();
            obj.unregister(observer1);
            obj.getChanged();
            Console.ReadKey();
        }
    }
}
