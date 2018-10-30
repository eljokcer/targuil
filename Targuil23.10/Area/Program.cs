using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter width");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Lenght");
            double l = double.Parse(Console.ReadLine());

            double area = w * l;
            double scope = (w * 2) + (l * 2);

            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The scope is: " + scope);
        }
    }
}
