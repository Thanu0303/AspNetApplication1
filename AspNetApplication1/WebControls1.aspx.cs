using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class WebControls1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> intrestList = new List<string> {"Art" ,"Technologies","Fashion","Automobiles",
            "Dance","Music","Sports","Science","Cuisines"};

            if (!IsPostBack)                    // the request is a new request or postback(on click of submit button request
            {  // if it is not a postback req 
                //then do the assignment as below  
              //  CheckBox1.DataSource = intrestList;
              //  CheckBox1.DataBind();                     //Bind the string items into the list-item
           


        //alternate way of doing above code is
        for (int i = 0; i<intrestList.Count; i++)
			{
                    CheckBox1.Items.Add(intrestList[i]);
            }


            }//otherwise ignore the assignment
        }// since the assignment is not made the selected values will be available

        protected void btnSave_Click(object sender , EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<section class = 'alert alert-info'> ");
            sb.AppendFormat("Hi,<b>{0}</b>! <br/> ", txtName.Text)
                .Append("Welcome to our site. You are located in ")
                .AppendFormat("<strong>{0}</strong> ", DropDown1.SelectedItem.ToString())
                .AppendFormat("<address>{0}</address> ", txtAdd.Text)
                .Append("<br/> Your intrest are : ")
                .Append("<ul>");
            foreach (ListItem item in CheckBox1.Items)
            {
                if(item.Selected)
                {
                    sb.AppendFormat("<li>{0}</li>", item.Text);
                }
               
            }
            sb.Append("</ul>");
            sb.Append("</section>");
            literal1.Text = sb.ToString();
        }
    }
}