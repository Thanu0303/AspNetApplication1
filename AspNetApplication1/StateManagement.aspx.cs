using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Text;

namespace AspNetApplication1
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            int counter = Convert.ToInt32(Application["counter"]);
            counter++;
            lblApplication.Text = counter.ToString();
            Application["counter"] = counter;
            Application.UnLock();

            counter = Convert.ToInt32(Application["counter"]);
            counter++;
            lblSession.Text = counter.ToString();
            Session["counter"] = counter;
        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            System.Web.HttpCookie cookie = new HttpCookie(
                name: txtName.Text,
                value: txtValue.Text);
            //Make a persistent cookie by setting the expirse property
           // cookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(cookie);
            lblMessage.Text = "WOW ! Success in saving cookie";
            lblMessage.BackColor = Color.Green;
            lblMessage.ForeColor = Color.White;
            lblMessage.Font.Size = new FontUnit(20.0);
               
        }

       
        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            StringBuilder bldr = new StringBuilder();
            bldr.Append("<h3> Cookies are: </h3>")
                .Append("<ul>");
            foreach (string key in Request.Cookies)
            {
                bldr.AppendFormat("<li><b>{0}</b> : {1}</li>",
                    key, Request.Cookies[key].Value);
            }
            bldr.Append("</ul>");
            lblMessage.BackColor = Color.White;
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = bldr.ToString();
        }
    }
}