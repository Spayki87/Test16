using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кратные_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 27;
            int number = random.Next(minNumber, maxNumber + 1);
            int minRangeNumber = 100;
            int maxRangeNumber = 999;
            int multiplesCounter = 0;

            Console.WriteLine(number + " - рандомное число");

            for (int i = number; i <= maxRangeNumber; i += number)
            {
                if (i >= minRangeNumber)
                {   
                    multiplesCounter++;
                    Console.WriteLine(multiplesCounter + " " + i);
                }
            }

            Console.WriteLine(multiplesCounter + " - количество кратных чисел.");
        }
    }
}
