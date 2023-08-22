using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Full Name";
            byte age = 0;
            string email = "Your email";
            float scoresIt = 0f;
            float scoresMath = 0f;
            float scoresPhys = 0f;

            Console.WriteLine($"Full name: {fullName}\n" +
                $"Age: {age}\n" +
                $"Email: {email}\n" +   
                $"IT scores: {scoresIt}\n" +
                $"Mathematics scores: {scoresMath}\n" +
                $"Physics scores: {scoresPhys}");
            Console.ReadKey();
        }
    }
}
