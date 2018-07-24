using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public int calculateDays(int day, int Month, int year)
        {
            DateTime dt = new DateTime(year, Month, day);
            //int datetodays = DateTime.Now.Subtract(dt).Days;
            int datetodays = new DateTime(DateTime.Now.Subtract(dt).Ticks).Year - 1;
            return datetodays;
        }

        public string GetMessage(string Name)
        {
            return "Hello" + Name;
        }
    }
}
