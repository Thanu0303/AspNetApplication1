using AspNetApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class ProductMaster : System.Web.UI.Page
    {
        #region Private Helpers
        public void InitializePage()
        {
            txtSearch.Text = string.Empty;
            FetchProductData();
        }
        
        public void FetchProductData()
        {
            //cache is sensitive to changes,it wont work
            if(Cache["productList"] == null)
            {
                
            try
            {
                ProductProcess process = new ProductProcess();
                var list = process.GetProducts(txtSearch.Text);
                    Cache["productList"] = list;
                    this.grid1.DataSource = list;
                    this.grid1.DataBind();
                   
            }
            catch (Exception)
            {
                throw;
            }
            }
            else {
                var list = Cache["productList"] as List<Product>;
                this.grid1.DataSource = list;
                this.grid1.DataBind();
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                InitializePage();
            }

        }
        

        #region Page Event Handlers
        protected void btnCreateNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateProduct.aspx");
        }      

        protected void btnLink1_Click1(object sender, EventArgs e)
        {
            FetchProductData();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            FetchProductData();
        }

        #endregion

        protected void grid1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grid1.PageIndex = e.NewPageIndex;
            FetchProductData();
        }

        protected void grid1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string id = grid1.DataKeys[e.NewEditIndex].Value.ToString();
            Response.Redirect("UpdateProduct.aspx?ID=" + id);
        }
    }
}