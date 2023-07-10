using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_с_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 12;
            int maxNamber = 999;
            int remainder = maxNamber % N;
            int difference = N - remainder;

            int count = difference / N + 1;

            Console.WriteLine(count);
        }
    }
}
