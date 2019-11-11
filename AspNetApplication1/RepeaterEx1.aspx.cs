using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class RepeaterEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateData();
            }
        }

        string connecttionstring = "server=BHIMA\\SQLDEV2016;database=Northwind;integrated security = sspi";
        string sql = "Select CustomerId, CompanyName,ContactName,City,Country from Customers";
        DataSet ds;
        SqlDataAdapter adapter;
        string tableName = "Customers";

        private void PopulateData()
        {
            if(adapter == null)
            
                adapter = new SqlDataAdapter(sql, connecttionstring);
                if (ds == null)
                    ds = new DataSet();
                adapter.Fill(ds, tableName);
                this.rep1.DataSource = ds;
                rep1.DataMember = tableName;
                rep1.DataBind();
            
        }
    }
}