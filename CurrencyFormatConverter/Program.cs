using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Default;
            //Console.OutputEncoding = Encoding.UTF8;

            double num1;
            double num2;
            double num3;

            Console.WriteLine("Input your first value:");
            num1 = double.Parse(Console.ReadLine());
            num1 = Math.Round(num1, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine("Input your second value:");
            num2 = double.Parse(Console.ReadLine());
            num2 = Math.Round(num2, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine("Input your third value:");
            num3 = double.Parse(Console.ReadLine());
            num3 = Math.Round(num3, 2, MidpointRounding.AwayFromZero);

            double total = num1 + num2 + num3;
            total = Math.Round(total, 2, MidpointRounding.AwayFromZero);

            double average = total / 3;
            average = Math.Round(average, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine("Your total is {0}", total.ToString("C"));
            Console.WriteLine("Your average is {0}", average.ToString("C"));

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("The highest number is " + num1.ToString("C"));
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("The highest number is " + num2.ToString("C"));
            else
                Console.WriteLine("The highest number is " + num3.ToString("C"));

            if (num1 < num2 && num1 < num3)
                Console.WriteLine("The lowest number is " + num1.ToString("C"));
            else if (num2 < num1 && num2 < num3)
                Console.WriteLine("The lowest number is " + num2.ToString("C"));
            else
                Console.WriteLine("The lowest number is " + num3.ToString("C"));

            var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();

            Console.WriteLine("US: " + total.ToString("C"));

            Console.WriteLine("Swedish: " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));

            Console.WriteLine("Japanese: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            Console.WriteLine("Thai: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

        }
    }
}
