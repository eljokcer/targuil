using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenght of the first side of the triangle");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Lenght of the second side of the triangle");
            double b = double.Parse(Console.ReadLine());

            double c = (a * a) + (b * b);
            Console.WriteLine("The lenght of the third part is: " + Math.Sqrt(c));
        }
    }
}
