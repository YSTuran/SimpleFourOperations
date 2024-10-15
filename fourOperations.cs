using System;

namespace experimental
{
    class fourOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plese enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of these numbers: " + a + b);

            int c = a-b;    
            Console.WriteLine("Subtraction of these numbers: " + c );

            int d = a * b;
            Console.WriteLine("Multiplication of these numbers: " + d);

            double e = (double) a / b;
            Console.WriteLine("Division of these numbers: " + e);




        }
    }


}
