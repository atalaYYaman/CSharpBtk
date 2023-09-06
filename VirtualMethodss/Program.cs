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
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            MySqlServer mySql = new MySqlServer();
            mySql.Add();
            mySql.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added from database");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted from database");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql Code");
            //base.Delete();
        }
    }

    class MySqlServer : Database
    {
        public override void Add()
        {
            base.Add();
        }
        public override void Delete()
        {
            base.Delete();
        }
    }
}
