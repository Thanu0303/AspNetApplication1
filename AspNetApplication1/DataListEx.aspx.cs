using AspNetApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class DataListEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateData();
            }
        }
        private void PopulateData()
        {
            CustomerDataAccess dataAccess = new CustomerDataAccess();
            var list = dataAccess.GetCustomers();
            dataList1.DataSource = list;
            dataList1.DataBind();
        }

        protected void dataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "View")
                Response.Redirect("CustomerDetails.aspx?ID=" + id);
        }

        protected void dataList1_EditCommand(object source, DataListCommandEventArgs e)
        {
            //enables the edit item templatye for the selected row
            //the selected row is the  one on which the command button is selected
            dataList1.EditItemIndex = e.Item.ItemIndex;
            PopulateData();
        }

        protected void dataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {

            string custId = dataList1.DataKeys[e.Item.ItemIndex].ToString();
            //since txtCompany is not availaible so extracting indirectly and casting it to textbaox
            string company = ((TextBox)e.Item.FindControl("txtCompany")).Text;           
            string contact = ((TextBox)e.Item.FindControl("txtContact")).Text;
            string city = ((TextBox)e.Item.FindControl("txtCity")).Text;
            string country = ((TextBox)e.Item.FindControl("txtCountry")).Text;

            Customer obj = new Customer
            {
                CustomerId = custId,
                CompanyName = company,
                ContactName = contact,
                City = city,
                Country = country
            };
            try
            {
                CustomerDataAccess dataAccess = new CustomerDataAccess();
                dataAccess.UpdateCustomer(obj);

            }catch(Exception ex)
            {
                throw ex;
            }
            

            //De-select the EditItemIndex by resetting the EditItemIndex to -1

            //to extract the primary key based on the current selection use datakeys
                                                                                                  

            dataList1.EditItemIndex = -1;
            PopulateData();
        }

        protected void dataList1_CancelCommand(object source, DataListCommandEventArgs e)
        {
            dataList1.EditItemIndex = -1;
            PopulateData();
        }

        protected void dataList1_DeleteCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}