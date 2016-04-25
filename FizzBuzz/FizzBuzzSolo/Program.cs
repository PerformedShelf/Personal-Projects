using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int value = 1; value <= 100; value++)
            {
                string output = "";
               
                if (value % 3 == 0) output = "Fizz";
                if (value % 5 == 0) output += "Buzz";
                if (output == "") output = value.ToString();

                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
