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
        SqlConnection _connecition = new SqlConnection(@"server = (localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connecition);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connecition.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connecition.State == ConnectionState.Closed)
            {
                _connecition.Open();
            }
        }

        public DataTable GetAll2()
        {
            
            if (_connecition.State == ConnectionState.Closed)
            {
                _connecition.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", _connecition);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connecition.Close();
            return dataTable;
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connecition);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connecition.Close();
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Insert into Products values (@name,@unitPrice,@stockAmount)", _connecition);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connecition.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connecition);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connecition.Close();
        }
    }
}
