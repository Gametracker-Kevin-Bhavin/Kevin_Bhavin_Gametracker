using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//required for identity and owin security

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Kevin_Bhavin_Gametracker
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //store session info and authentication method in authenticationmanager object
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            //signout the user
            authenticationManager.SignOut();
            System.Diagnostics.Debug.WriteLine("Logged out User!");
            this.Master.checkloginlogout();

            //redirect the user to home page
            Session.Clear();
            Response.Redirect("~/Register.aspx");
        }
    }
}