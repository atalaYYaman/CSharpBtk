using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.List();

            Product product1 = new Product(2, "Laptop");
            product1.ProductManager();

            Console.WriteLine("**************");
            Product product2 = new Product();
            product2.ProductManager();

            Console.WriteLine("**************");
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLoger());
            employeeManager.Add();

            Console.WriteLine("**************");
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed! {0} item", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        public Product()
        {

        }
        int _id = 0;
        string _name = "default";
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void ProductManager()
        {
            Console.WriteLine("This is {0}, it id is {1}", _name, _id);
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)//Bunu bir daha  sorsan iyi olur.
        {

        }
        public void Add()
        {
            Message();
            Console.WriteLine("Added!");
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething1()
        {
            Console.WriteLine("Done2");
        }
    }
}
