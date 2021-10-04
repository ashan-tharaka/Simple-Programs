using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String val;
            double n ;
            Console.WriteLine("Enter a Integer: ");
            val = Console.ReadLine();

            // convert to integer
            n = Convert.ToDouble(val);           
            Console.WriteLine("Number of Digits in "+n+" is "+Length(n));


        }

        public static int Length(double number)
        {
            number = Math.Abs(number);
            int length = 1;
            while ((number /= 10) >= 1)
                length++;
            return length;
        }
    }
}
