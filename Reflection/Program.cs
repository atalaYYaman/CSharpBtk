using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortıslem = new DortIslem(2,3);
            //Console.WriteLine(dortıslem.topla2());
            //Console.WriteLine(dortıslem.topla(3,4));

            var tip = typeof(DortIslem);

            //DortIslem dortıslem = (DortIslem)Activator.CreateInstance(tip,5,6);
            //Console.WriteLine(dortıslem.topla(4,5));
            //Console.WriteLine(dortıslem.topla2());

            var instance = Activator.CreateInstance(tip,5,6);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance));


            Console.ReadLine();
            
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;

        }
        

        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
