using AspNetApplication1.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AspNetApplication1
{
    public partial class RepeaterEx2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PopulateData1();
            }
        }

        string connecttionstring = "server=BHIMA\\SQLDEV2016;database=Northwind;integrated security = sspi";
        string sql = "Select CustomerId, CompanyName,ContactName,City,Country from Customers";
        DataSet ds;
        SqlDataAdapter adapter;
        string tableName = "Customers";

        private void PopulateData1()
        {
            //if (adapter == null)

            //    adapter = new SqlDataAdapter(sql, connecttionstring);
            //if (ds == null)
            //    ds = new DataSet();
            //adapter.Fill(ds, tableName);
            //this.rep2.DataSource = ds;
            //rep2.DataMember = tableName;
            //rep2.DataBind();

            CustomerDataAccess dataAccess = new CustomerDataAccess();
            var list = dataAccess.GetCustomers();
            rep2.DataSource = list;
            rep2.DataBind();

        }

        protected void rep2_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            string custId = e.CommandArgument.ToString();
            if(e.CommandName  == "View")
            {
                Response.Redirect("CustomerDetails.aspx?ID=" + custId);
            }
        }
    }
}
