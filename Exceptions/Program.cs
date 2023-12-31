﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //Method - Action Delegasyonu
            //ActionDemo();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };

            Func<int> getRandomNumber2 =()=> new Random().Next(1,100);

            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber());

            //Console.WriteLine(Topla(4,5));
            Console.ReadLine();
        }
        static int Topla(int x,int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>//Bu method içinde method kullanmak için bu şekilde yazılır.
            {
                Find();//Methodun içindeki action'nın yerine Find() methodunu getirdik.
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
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
