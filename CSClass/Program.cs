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

            List<Student> students = new List<Student>()
            {
            new Student() { name = "가연우1", grade = 100 },
            new Student() { name = "가연우2", grade = 99 },
            new Student() { name = "가연우3", grade = 98 },
            new Student() { name = "가연우4", grade = 97 },
            new Student() { name = "가연우5", grade = 45 },
            new Student() { name = "가연우6", grade = 12 },
            new Student() { name = "가연우7", grade = 56 },
            new Student() { name = "가연우8", grade = 80 },
            new Student() { name = "가연우9", grade = 43 },
            new Student() { name = "가연우10", grade = 3}
            };




            for (int i = students.Count - 1; i >= 0; i --) {
                if (students[i].grade >= 60) { 
                    students.RemoveAt(i);
                }
            }
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            Product product1 = new Product("감자",2000);
            Product product2 = new Product("고구마", 3000);
            
            Console.WriteLine(product1.id+" : "+product1.name);
            Console.WriteLine(product2.id + " : " + product2.name);
            Console.WriteLine(Product.count+"개가 생성되었습니다.");

            SingleTon singleTon = SingleTon.getInstance();

            Console.WriteLine("첫번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치");  

            Product product3 = new Product("과자",1500);
        }
    }
}
