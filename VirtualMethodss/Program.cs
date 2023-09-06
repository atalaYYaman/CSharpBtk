using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();//sa
            sqlServer.Add();
            MySqlServer mySql = new MySqlServer();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {

    }

    class MySqlServer : Database
    {

    }
}
