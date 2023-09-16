using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public DataTable GetAll()
        {
            SqlConnection connecition = new SqlConnection(@"server = (localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
            if(connecition.State==ConnectionState.Closed )
            {
                connecition.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connecition);

            SqlDataReader reader = command.ExecuteReader();

            DataTable  dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connecition.Close();
            return dataTable;
        }
    }
}
