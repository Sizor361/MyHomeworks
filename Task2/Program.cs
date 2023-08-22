using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float scores;
            int avg;

            scores = 5 + 4 + 5 + 2 + 4 + 3 + 4 + 2 + 2;
            avg = (int)scores / 9;

            Console.WriteLine("Ученик получил следующие оценки: 5, 4, 5, 2, 4, 3, 4, 2, 2");
            Console.ReadKey();
            Console.Write($"Его итоговая оценка - {avg}");
            Console.ReadKey();
        }
    }
}