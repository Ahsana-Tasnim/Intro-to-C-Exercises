using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ BMI Calculator ************");
            Console.WriteLine();

            Console.WriteLine("This application will calculate Body Mass Index ");
            Console.WriteLine("when the user supplies their weight in pounds and height in inches. ");
            Console.WriteLine();

            Console.Write("Please enter your weight in lbs: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            const double constNum = 703.00;
            double result = (weight * constNum) / (height * height);
            Console.WriteLine("Your BMI is " + result);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit. ");

            Console.ReadLine();
        }
    }
}
