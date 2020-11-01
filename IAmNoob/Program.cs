using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAmNoob
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World!";
            Console.WriteLine(greeting);

            greeting = greeting.Replace("Hello", "Goodbye");
            Console.WriteLine(greeting);

            Console.WriteLine(greeting.ToUpper());
            Console.WriteLine(greeting.ToLower());

            Console.WriteLine(greeting);

            var Goodbye = greeting.Contains("Goodbye");
            var Hello = greeting.Contains("Hello");

            Console.WriteLine(Hello);
            Console.WriteLine(Goodbye);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            float fmax = float.MaxValue;
            float fmin = float.MinValue;
            Console.WriteLine($"The range of floats is {fmin} to {fmax}");



            decimal dmax = decimal.MaxValue;                                            //decimal: smaller range, higher precision
            decimal dmin = decimal.MinValue;
            Console.WriteLine($"The range of decimals is {dmin} to {dmax}");

            double ddmax = double.MaxValue;                                             //double: higher range, smaller precision
            double ddmin = double.MinValue;
            Console.WriteLine($"The range of decimals is {ddmin} to {ddmax}");


            // So, why not use all the time the numerical variable that has the biggest range? TAKES UP MORE MEMORY





        }
    }
}
