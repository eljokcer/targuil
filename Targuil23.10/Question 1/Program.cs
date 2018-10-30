using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grades in math");
            double m = double.Parse (Console.ReadLine());
            Console.WriteLine("Enter your grades in english");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your grades in physics");
            double p = double.Parse(Console.ReadLine());

            double math = 0;
            math = m * 0.4;
            
            double english = 0;
            english = e * 0.2;

            double physics = 0;
            physics = p * 0.4;

            double average = 0;
            average = math + english + physics;

            Console.WriteLine("your average is: " + average);
        }
    }
}
