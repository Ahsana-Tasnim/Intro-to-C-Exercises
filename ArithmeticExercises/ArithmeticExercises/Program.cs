using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Perimeter Calculator************");
            Console.WriteLine();

            Console.WriteLine("This application will calculate Perimeter when given the length and width.");
            Console.WriteLine();

            Console.Write("What is the lenght? ");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            Console.Write("What is the width? ");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            decimal perimeter = (length * 2) + (width * 2);
            Console.WriteLine("The perimeter is " + perimeter);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();
        }
    }
}
