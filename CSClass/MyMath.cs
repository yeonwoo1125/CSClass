using System;

namespace CSClass
{
    class MyMath
    {
         public static int Abs(int v)
        {
            return (v<0) ? -1 : v;
        }

        void foo() 
        {
            Console.WriteLine("클래스 메서드에서 접근 불가");
        }
    }
}