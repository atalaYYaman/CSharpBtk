using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2] {"Ankara","İstanbul"};
            //cities = new string[3];
            //Console.WriteLine(cities[0]);

            //Arraylist();

            List<string> cities = new List<string>();
            cities.Add("Ankara");//Bundan sonra sadece string değeri verebiliriz.Çünkü ilk başta öyle tanımladık.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Ata" });
            //customers.Add(new Customer { Id = 2, FirstName = "Yaman" });

            //Diğer bir yazılış yöntemide şu şekildedir.
            List<Customer> customers = new List<Customer>
            {
            new Customer { Id = 1, FirstName = "Ata" },
            new Customer { Id = 2, FirstName = "Yaman" }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.ReadLine();
        }

        private static void Arraylist()
        {
            ArrayList cities = new ArrayList();//Sıfırdan bir referans oluşturduk.
            cities.Add("Ankara");
            cities.Add("Adana");//Burada herhangi bir sınır koymuyoruz istediğimiz kadar eleman ekleyebiliriz.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("İstanbul");
            cities.Add(1);//Parametre olarak bizden (object value) ister.Bütün tiplerin base'i (temeli) objedir.Dolayısıyla her veri tipini ekleyebiliriz.
            cities.Add('A');
            Console.WriteLine(cities[2]);//istediğimiz yerde eleman ekleyebiliriz ve hiçbir yerde new leme yapmadığımız için eleman kaybetmeyiz.
                                         //Genellikle programlarımızda typeSafe (Aynı türden object lerin bir listede tutulmasını) tercih ederiz.
                                         //Bu yüzden ArrayList tercih etmek yerine koleksiyonları kullanırız. 
        }

        class Customer//List'leri tek başına kullanmayız bu şekilde nesnelere çalışırız.
                      //Çünkü genellikle veritabanında programlama yaptığımız için veritabanındaki tablolarınız karşılığını veri halinde tutarsınız.
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
