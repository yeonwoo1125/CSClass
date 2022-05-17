using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.SetInTIme();
            car.SetOutTIme();

            Random rand = new Random();
            Console.WriteLine(rand.Next(10,100));
            Console.WriteLine(rand.Next(10, 100));
            Console.WriteLine(rand.Next(10, 100));
            Console.WriteLine(rand.Next(10, 100));
            Console.WriteLine(rand.Next(10, 100));

            Console.WriteLine(rand.NextDouble());
            Console.WriteLine(rand.NextDouble()*10);
        }
    }
}
