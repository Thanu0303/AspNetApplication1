﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetApplication1
{
    public partial class Validators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegularExpressionValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void cv3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "abcdef")
                args.IsValid = true;
            else
                args.IsValid = false;
        }
    }
}