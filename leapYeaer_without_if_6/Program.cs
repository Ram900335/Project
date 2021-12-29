//6)find a given year is leap year or not without using if block
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYeaer_without_if_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool newyear = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0) ? true : false;
            Console.WriteLine(newyear);
        }
    }
}
