using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Property Tax Calculator *************");
            Console.WriteLine();

            Console.WriteLine("Property tax is calculated as $3.12 per $500 of the property's values. ");
            Console.WriteLine();

            Console.Write("What is the value of the property? ");
            double valueofProperty = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double totalTax = (valueofProperty * 3.12) / 500;

            Console.WriteLine($"You owe {totalTax.ToString("C")} in property tax on your property valued at {valueofProperty.ToString("C")}");
            Console.WriteLine();

            Console.WriteLine("Press any to exit. ");

            Console.ReadLine();
        }
    }
}
