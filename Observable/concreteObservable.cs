using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservablePattern.Observer;

namespace ObservablePattern.Observable
{
    public class concreteObservable : IObservable
    {
        IList<IObserver> list;
        string sms;
        public concreteObservable()
        {
            list = new List<IObserver>();
        }

        public string getSms()
        {
            return "Hi! how are you?";
        }
        public void notify()
        {
            foreach(IObserver  obj in list)
            {
                obj.update(sms);
            }
        }

        public void register(IObserver Obj)
        {
            list.Add(Obj);
        }

        public void unregister(IObserver Obj)
        {
            list.Remove(Obj);
        }

        public void getChanged()
        {
            sms = getSms();
            notify();
        }
    }
}
