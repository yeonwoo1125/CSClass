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

/*            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);*/
            List<int> list = new List<int>() { 1,2,3,4};

            foreach (int i in list) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
