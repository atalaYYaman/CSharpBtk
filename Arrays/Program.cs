using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ata";
            students[1] = "Osman";
            students[2] = "Salih";

            string[] students2 = new[] {"Ali","Emre","Mahmud" };

            string[] students3 ={ "Cevat", "Kemal", "Hasan" };

            //foreach (var student in students3)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[4, 3] //Çok boyutlu dizi. 
            {
                {"İst","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Urfa","Antep","Diyarbakır" },
                {"Rize","Artvin","Giresun" },
                
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j<= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("************");
            }

            Console.ReadLine();

        }

            
        
    }
}
