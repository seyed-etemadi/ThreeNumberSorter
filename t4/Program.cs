using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, smallest, middle, largest;
            // دریافت سه عدد از کاربر
            Console.WriteLine("Please enter three numbers : ");
            Console.WriteLine("Num 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 3 :");
            num3 = Convert.ToInt32(Console.ReadLine());



            // یافتن کوچک‌ترین عدد
            if (num1 <= num2 && num1 <= num3)
            {
                smallest = num1;
                if (num2 <= num3)
                {
                    middle = num2;
                    largest = num3;
                }
                else
                {
                    middle = num3;
                    largest = num2;
                }
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                smallest = num2;
                if (num1 <= num3)
                {
                    middle = num1;
                    largest = num3;
                }
                else
                {
                    middle = num3;
                    largest = num1;
                }
            }
            else
            {
                smallest = num3;
                if (num1 <= num2)
                {
                    middle = num1;
                    largest = num2;
                }
                else
                {
                    middle = num2;
                    largest = num1;
                }
            }

            // چاپ اعداد به ترتیب
            Console.WriteLine($" Numbers in order from smallest to largest : {smallest}, {middle}, {largest}");
            Console.ReadKey();
        }
    }
}
