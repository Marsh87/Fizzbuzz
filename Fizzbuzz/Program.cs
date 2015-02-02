using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        public static void Print()
        {
            for (int i = 0; i <= 100; i++)
            {
                bool three=false;
                bool five=false ;
                bool both=false;

                if (i%3 == 0)
                {
                    three = true;
                }
                if (i%5 == 0)
                {
                    five = true;
                }
                if (three == true && five == true)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(three==true)
                {
                    Console.WriteLine("Fizz");
                }
                else if (five == true)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
