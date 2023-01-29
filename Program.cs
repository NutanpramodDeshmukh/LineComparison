using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class GFG
    {
        
        static void Length()
        {
            Console.Write("Enter Lengths");

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Length of a Line is");
            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
            


        }

        
        public static void Main()
        {
           
            Length();
        }
    }
}
