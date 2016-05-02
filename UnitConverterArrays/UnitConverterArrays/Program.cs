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
            double input = 4;
            double mileConvert = 0.62137;
            float miles = (float)input * (float)mileConvert;
            Console.WriteLine(miles);
            Console.ReadLine();

        }
    }
}
