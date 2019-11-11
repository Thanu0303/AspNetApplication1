using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AspNetApplication1
{
    public class Global : System.Web.HttpApplication
    {
        //handles events at the application level,when excptn not handled appcn obj got crashed. 
        //after that a new obj is created
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    HttpContext.Current.Response.Write("Hello - Begin Request");
        //}

        //protected void Application_EndRequest(object sender, EventArgs e)
        //{
        //    HttpContext.Current.Response.Write("Hello - End Request");
        //}


    }
}