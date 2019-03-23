using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            // Create Math proxy 
            CalculateProxy proxy   = new CalculateProxy();

            // Do some Calculations
            double add = proxy.Add(2, 5);
            double sub = proxy.Subtract(2, 5);
            double mul = proxy.Multiply(2, 5);
            double div = proxy.Divide(2, 5);

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);

            Console.ReadKey();

        }
    }
}
