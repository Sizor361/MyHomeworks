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
            int result;

            scores = (5 + 4 + 5 + 2 + 4 + 3 + 4 + 2 + 2) / 9f;

            if (scores - (int)scores >= 0.5 && scores - (int)scores != 0) //условие на округление оценки в большую сторону при 0.5 остатке и выше
            {
                scores++;
            }

            result = (int)scores;
            Console.WriteLine("Ученик получил следующие оценки: 5, 4, 5, 2, 4, 3, 4, 2, 2");
            Console.ReadKey();
            Console.Write($"Его итоговая оценка - {result}");
            Console.ReadKey();
        }
    }
}