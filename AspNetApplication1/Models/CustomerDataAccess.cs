using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetApplication1.Models
{
    
    public class CustomerDataAccess
    {
        string connectionString = string.Empty;
        SqlConnection connection;

        public CustomerDataAccess()
        {
            var constr = ConfigurationManager
                .ConnectionStrings["NorthWindConnectionString"].ConnectionString;
            connectionString = constr;
            connection = new SqlConnection(connectionString);
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> custList = new List<Customer>();
            string sql = "Select CustomerId, CompanyName, ContactName, City, Country from Customers";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader= null;
            try
            {
                connection.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    Customer obj = new Customer
                    {
                        CustomerId = reader.GetString(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader.GetString(2),
                        City = reader.GetString(3),
                        Country = reader.GetString(4),
                    };
                    custList.Add(obj);
                }

            }catch(SqlException)
            {
                throw;
               
            }catch(Exception)
            {
                throw;
            }
            finally
            {
               if(reader != null)if(!reader.IsClosed) reader.Close();
                if (connection.State != ConnectionState.Closed) connection.Close();
                connection = null;
            }
            return custList;
        }
        public void UpdateCustomer(Customer item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Value is null.");

            string sql = " Update Customers set CompanyName=@company, " +
                "ContactName=@contact, City=@city, Country=@country " +
                "where CustomerId=@customerId ";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@company", item.CompanyName);
            command.Parameters.AddWithValue("@contact", item.ContactName);
            command.Parameters.AddWithValue("@city", item.City);
            command.Parameters.AddWithValue("@country", item.Country);
            command.Parameters.AddWithValue("@customerId", item.CustomerId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {               
                if (connection.State != ConnectionState.Closed) connection.Close();
                connection = null;
            }
        }
    }
}
