using ObservablePattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern.Observable
{
    public interface IObservable
    {
        void register(IObserver Obj);
        void unregister(IObserver Obj);
        void notify();
    }
}
