using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(5);
            //Console.WriteLine(result);
            //Console.ReadLine();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Add4(1,2,3,8));
            Console.ReadLine();
        }

        //static void Add()
        //{
        //    Console.WriteLine("Added!");
        //}

        //static int Add2(int number1, int number2 = 10) //number2 verilmezse default olarak 30 al.
        //{
        //    var result = number1 + number2;
        //    return result;
        //}
        static int Add3(ref int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
           
        }

        static int Multiply(int number1 , int number2) 
        {
            return number1 * number2;
        }

        static int Add4(params int[] number)
        {
            return number.Sum();
        }
    }
}
