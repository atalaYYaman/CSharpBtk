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

            //Console.WriteLine(cities.Contains("Ankara"));//Çıktı true döner çünkü aynı eleman içeride de var.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //------------------------------------------
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Ata" });
            //customers.Add(new Customer { Id = 2, FirstName = "Yaman" });

            //Diğer bir yazılış yöntemide şu şekildedir.
            List<Customer> customers = new List<Customer>
            {
            new Customer { Id = 1, FirstName = "Ata" },
            new Customer { Id = 2, FirstName = "Yaman" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Azra"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
                {
                    new Customer { Id = 4, FirstName ="Ali"},
                    new Customer { Id = 5, FirstName = "Ayşe"}
                });

            Console.WriteLine(customers.Contains(customer2));//Bunun içerisine new'leyerek koyduğumuz herşey false döndürür.

            //customers.Clear();//İçerisinde ki verileri siler.

            var index = customers.IndexOf(customer2);//IndexOf bize listedeki elemanın listede kaçıncı sırada olduğunu verir.
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);//LastIndexOf sondan başlayarak tarama yapar.
            Console.WriteLine("Index: {0}", index2);

            customers.Insert(0, customer2);//Add her zaman değeri en sona eklerken. Insert değeri istediğimiz yere eklememizi sağlar.

            customers.Remove(customer2);//İstediğimiz değeri kaldırır ancak bunu bir defa yapabilir ve sonrasında aramayı bırakır.
                                        //Eğer o değerden birden fazla varsa sadece biri gider.

            //Bu konuyu daha bilmiyoruz ama kısaca listedeki aynı türden değerlerin hepsini bu şekilde silebiliriz.
            customers.RemoveAll(c => c.FirstName == "Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count;//İçerdeki veri sayısını söyler ama öncesinde Clear attığımız için şuan sıfır döndürür.
            Console.WriteLine("Count: {0}", count);
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
