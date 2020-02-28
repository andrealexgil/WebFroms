using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using WebSite1;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LogIn(object sender, EventArgs e)
        {

        }
        
        [System.Web.Services.WebMethod(EnableSession = true)]
        public static string Hi()
        {
            return "Hello World";
        } 
}