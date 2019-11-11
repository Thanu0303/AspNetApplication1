using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class WebContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("<section class = 'alert alert-info'> ");
            //sb.AppendFormat("Hi,<b>{0}</b>! <br/> ", txtFName.Text)
            //    .Append("Welcome to our site. Your emailId is  ")
            //    .AppendFormat("<strong>{0}</strong> ", DropDown1.SelectedItem.ToString())
            //    .AppendFormat("<address>{0}</address> ", txt.Text)
            //    .Append("<br/> Your intrest are : ")
            //    .Append("<ul>");
            //foreach (ListItem item in CheckBox1.Items)
            //{
            //    if (item.Selected)
            //    {
            //        sb.AppendFormat("<li>{0}</li>", item.Text);
            //    }

            //}
            //sb.Append("</ul>");
            //sb.Append("</section>");
            literal1.Text = "Thank you for registering with our site";
        }

        //protected void cv3_ServerValidate(object source, ServerValidateEventArgs args)
        //{

        //}

        //protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        //{

        //}
    }
}