using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Remove();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();

            Customer customer = new Customer();
            customer.City = "Konya";
            customer.FirstName = "Ata";
            customer.LastName = "Yaman";
            customer.Id = 1;

            Console.WriteLine("*********");
            Console.WriteLine(customer.City);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);

            Customer customer2 = new Customer();
            customer2.City = "Konya2";
            customer2.FirstName = "Ata2";
            customer2.LastName = "Yaman2";
            customer2.Id = 2;

            Console.WriteLine("*********");
            Console.WriteLine(customer2.City);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.Id);

            Console.ReadLine();
        }
    }
    
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Remove()
        {
            Console.WriteLine("Customer Removed");
        }
    }
}
