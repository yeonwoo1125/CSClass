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

            Console.WriteLine(Math.Abs(-23421));
            Console.WriteLine(Math.Ceiling(4.3333));
            Console.WriteLine(Math.Floor(5434.34343));
            Console.WriteLine(Math.Round(4543.1324));
            Console.WriteLine(Math.Round(4543.1327,4));
            Console.WriteLine(Math.Max(4,6));
            Console.WriteLine(Math.Min(435,234));

/*            Product product = new Product();
            product.name = "고구마";
            product.price = 6000;*/

            Product product = new Product() {name="고구마",price=2000 };

            Console.WriteLine(product.ToString());
        }
    }
}
