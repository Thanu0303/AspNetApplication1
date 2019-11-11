using AspNetApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        private void InitializePage()
        {

        }
        private void PopulateCategories()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            string sql = "select CategoryId, CategoryName from Categories";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Categories");
            ddlCategories.DataSource = ds.Tables["Categories"];
            ddlCategories.DataTextField = "CategoryName";
            ddlCategories.DataValueField = "CategoryId";
            ddlCategories.DataBind();
        }
        private void AssignValuesToTextboxes(Product model)
        {
            txtName.Text = model.ProductName;
            txtPrice.Text = model.UnitPrice.ToString();
            txtStock.Text = model.UnitsInStock.ToString();
            chkDiscontinued.Checked = model.Discontinued;
           ddlCategories.SelectedValue = model.CategoryId.ToString();
        }

        private Product RetreiveValuesFromControls()
        {
            Product model = new Product();
            model.ProductName = txtName.Text;
            model.UnitPrice = Convert.ToDecimal("0" + txtPrice.Text);
            model.UnitsInStock = Convert.ToInt16("0" + txtStock.Text);
            model.Discontinued = chkDiscontinued.Checked;
            model.CategoryId = Convert.ToInt32("0" + ddlCategories.SelectedValue);
            model.ProductId = Convert.ToInt32("0" + Request.QueryString["id"]);
            return model;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializePage();
                //PopulateCategories();
                // LoadProductDetails();
            }
        }

        private void SaveProductDetails()
        {
            Product obj = RetreiveValuesFromControls();
            ProductProcess process = new ProductProcess();
            process.Createproduct(obj);
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SaveProductDetails();
            Cache.Remove("productList");                  //invalidating the cache,it will become null
            // Cache["productList"] = null;                alternate way of doing above line
            Response.Redirect("ProductMaster.aspx");
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductMaster.aspx");
        }
    }
}