using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Line");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Second Line");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Lengthis :", Length);

            double LengthTwo = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Lenght", LengthTwo);
            double Result = Length.CompareTo(LengthTwo);
            Console.WriteLine("Result", Result);
            if (Length == (LengthTwo))
            {
                Console.WriteLine("First Line is Greater");
            }
            else if (Length != (LengthTwo))
            {
                Console.WriteLine("Second Line is Greater");
            }
            else
            {
                Console.WriteLine("First and Second Lines are not Equal");
            }
        }
    }
}
