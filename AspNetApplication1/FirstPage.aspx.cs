using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    //partial class is a class which is spread across multiple physical files
    public partial class FirstPage : System.Web.UI.Page      // must inherit this one and cut the sript
    {
        protected TextBox txt1; //base class object is declared and initialized by child class( in .aspx)

        protected override void OnInit(EventArgs e)
        {
            this.Load += new EventHandler(Page_Load);
            base.OnInit(e);
        }
        public void Page_Load(object sender, EventArgs e)
        {
            // check whether the request is a new request or a postback request
            if (!IsPostBack)
                this.txt1.Text = "Enter your name here";
        }
        //public delegate void System.EventHandler(object sender, EventArgs e);
        public void btn1_Click(object sender, EventArgs e)
        {
            this.txt1.Text = this.txt1.Text.ToUpper();
        }
    }
}