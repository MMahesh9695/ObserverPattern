using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern.Observer
{
    public class ConcreteObserver2 : IObserver
    {
        string sms;
        public void update(string sms)
        {
            this.sms = sms;
            Console.WriteLine("observer 2:{0}", sms);
        }
    }
}
