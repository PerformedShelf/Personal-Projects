using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose a conversion:");
            Console.WriteLine("1) Kilometers to Miles");
            Console.WriteLine("2) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                MileConvert();
                return true;
            }
            else if (result == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void MileConvert()
        {
            Console.Clear();
            Console.WriteLine("Kilometer to Mile Conversion");
            Console.Write("Type a measure in kilometers: ");
            double input = double.Parse(Console.ReadLine());

            double convert = 0.62137;
            float miles = (float)input * (float)convert;
            Console.WriteLine(input + " kilometers = " + miles + "miles");
            Console.ReadLine();

        }
    }
}
