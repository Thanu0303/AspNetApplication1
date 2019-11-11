using System;
using System.Data;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetApplication1.Models
{
    internal class ProductDAO
    {
        const string GETALL = "SP_GETALLPRODUCTS";
        const string GETDETAILS = "SP_GETALLPRODUCT";
        const string INSERT = "SP_INSERTPRODUCT";
        const string UPDATE = "SP_UPDATEPRODUCT";

        SqlConnection con;
        string constring = "server=BHIMA\\SQLDEV2016;database=northwind;integrated security=true";

        #region Helper Methods
        public void CreateConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(constring);
            }

        }
        public void OpenConnection()
        {
            if (con == null)
            {
                CreateConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }

        private void CloseConnection()
        {
            if (con != null)
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                    con = null;
                }
            }
        }

        private Product CreateProductFromReader(SqlDataReader reader)
        {
            Product p = new Product();
            p.ProductId = Convert.ToInt32("0" + reader["ProductId"].ToString());
            p.ProductName = reader["ProductName"].ToString();
            p.UnitPrice = Convert.ToDecimal("0" + reader["UnitPrice"].ToString());
            p.UnitsInStock = Convert.ToInt16("0" + reader["UnitsInStock"].ToString());
            p.Discontinued = Convert.ToBoolean(reader["Discontinued"].ToString());
            p.CategoryId = Convert.ToInt32("0" + reader["CategoryId"].ToString());
            return p;

        }
        #endregion

     // DataAccess Public Methods
        public List<Product> GetProducts(string criteria)
        {
            // check whether the arg is passed or not
            //  if (string.IsNullOrEmpty(criteria))
            // {
            //    throw new ArgumentNullException(nameof(criteria), "Required arg mising");
            //  }
            List<Product> productList = new List<Product>();
            // create the coomand and setup the parameters
            CreateConnection();
            SqlCommand command = con.CreateCommand();
            command.CommandText = GETALL;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.AddWithValue("@SEARCH", criteria);
            //open the coonection and execute the statements within the try catch bloak
            SqlDataReader reader = null;
            try
            {
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var product = CreateProductFromReader(reader);
                    productList.Add(product);
                }
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
                if (reader != null) if (!reader.IsClosed) reader.Close();
                CloseConnection();
            }
            return productList;
        }

        public Product GetProduct(int productId)
        {
            // check whether the arg is 0 or not
            //if (int.MinValue < 0)
            //{
            //    throw new ArgumentNullException("Id cannot be zero");
            //}
            Product product1 = new Product();
            // create the coomand and setup the parameters
            CreateConnection();
            SqlCommand command = con.CreateCommand();
            command.CommandText = GETDETAILS;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            command.Parameters.AddWithValue("@PROCTID", productId);
            //open the coonection and execute the statements within the try catch bloak
            SqlDataReader reader = null;
            try
            {
                OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product1 = CreateProductFromReader(reader);
                    //  product1.add(product);
                }
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
                if (reader != null) if (!reader.IsClosed) reader.Close();
                CloseConnection();
            }
            return product1;
        }


        public void Createproduct(Product item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Required argument missing.");
            CreateConnection();
            //Build a command and assign all the the parameters
            SqlCommand command = new SqlCommand(INSERT, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@PROCTNAME";
            p1.SqlDbType = SqlDbType.VarChar;
            p1.Size = 50;
            p1.Direction = ParameterDirection.Input;
            p1.Value = item.ProductName;
            command.Parameters.Add(p1);
            command.Parameters.Add(new SqlParameter("@unitprice", item.UnitPrice));
            command.Parameters.Add(new SqlParameter("@unitsinstock", item.UnitsInStock));
            command.Parameters.Add(new SqlParameter("@discontinued", item.Discontinued));
            command.Parameters.Add(new SqlParameter("@categoryid", item.CategoryId));


            OpenConnection();
            SqlTransaction trans = con.BeginTransaction();
            command.Transaction = trans;

            try
            {
                command.ExecuteNonQuery();
                trans.Commit();

            }
            catch (SqlException)
            {
                trans.Rollback();
                throw;
            }

            catch (Exception)
            {
                trans.Rollback();
                throw;
            }
            finally
            {
                CloseConnection();
            }


        }

        public void UpdateProduct(Product item)
        {
            if (item == null)
                throw new ArgumentException(nameof(item), "");
            else
            {
                CreateConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = UPDATE;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter();
                p1.ParameterName = "@PROCTNAME";
                p1.SqlDbType = SqlDbType.VarChar;
                p1.Direction = ParameterDirection.Input;
                p1.Value = item.ProductName;
                command.Parameters.Add(p1);
                command.Parameters.AddWithValue("@unitprice", item.UnitPrice);
                command.Parameters.AddWithValue("@unitsinstock", item.UnitsInStock);
                command.Parameters.AddWithValue("@discontinued", item.Discontinued);
                command.Parameters.AddWithValue("@catgryid", item.CategoryId);
                command.Parameters.AddWithValue("@PRODUCTID", item.ProductId);
                OpenConnection();
                SqlTransaction trans = con.BeginTransaction();
                command.Transaction = trans;
                try
                {
                    command.ExecuteNonQuery();
                    trans.Commit();
                }
                catch (SqlException)
                {
                    trans.Rollback();
                    throw;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
    }
}