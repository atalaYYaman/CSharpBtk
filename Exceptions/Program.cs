using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] {"Ata","Yaman","Azra"};
                students[3] = "Ahmet";
            }
            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            

            Console.ReadLine();
        }
    }
}
