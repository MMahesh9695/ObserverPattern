using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern.Observer
{
    public class ConcreteObserver1 : IObserver
    {
        string sms;
        public void update(string sms)
        {
            this.sms = sms;
            Console.WriteLine("observer 1:{0}", sms);
        }
    }
}
