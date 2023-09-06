using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            //if (IsPrimeNumber(7))
            //{
            //    Console.WriteLine("This is a prime number");
            //}
            //else 
            //{
            //    Console.WriteLine("This is not a prime number.");
            //}

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.EndsWith("kuf");

            var result5 = sentence.IndexOf(" ");

            Console.WriteLine(result3);
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number%i== 0)
                {
                    result = false;
                    break;
                }
            }
            return result;

        }


        private static void ForeachLoop()
        {
            string[] students = new[] { "Ali", "Ahmet", "Ayşe" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number++;

            } while (number <= 10);
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        static void ForLoop()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");
        }
        
    }
}
