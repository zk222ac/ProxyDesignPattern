using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    // The Proxy Object Class
    // The client will use to invoke the operation ( add , subtract , divide)
    // all method internal implementation hide it from the client , client does not know about anything
   public class CalculateProxy : IMath
    {
        private Math _math = new Math();
        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return _math.Subtract(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }

        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }
    }
}
