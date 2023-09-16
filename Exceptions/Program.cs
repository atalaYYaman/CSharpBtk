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
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //Method
            HandleException(() =>//Bu method içinde method kullanmak için bu şekilde yazılır.
            {
                Find();//Methodun içindeki action'nın yerine Find() methodunu getirdik.
            }); 

            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ata", "Yaman", "Azra" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ata", "Yaman", "Azra" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
