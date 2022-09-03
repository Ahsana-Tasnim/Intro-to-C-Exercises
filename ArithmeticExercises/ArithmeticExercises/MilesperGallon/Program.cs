using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesperGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ MPG Calculator ************");
            Console.WriteLine();

            Console.WriteLine("This application will calculate Miles Per Gallon ");
            Console.WriteLine("when the user supplies the # of gallons the car can hold and ");
            Console.WriteLine("the # of miles it can be driven on a full tank. ");
            Console.WriteLine();

            Console.Write("How many gallons can the car hold? ");
            int gallonNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many miles can it be driven on full tank? ");
            decimal miles = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            decimal result = miles / (Convert.ToDecimal(gallonNumber));
            Console.WriteLine("Miles per gallon is " + result);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit. ");

            Console.ReadLine();
        }
    }
}
