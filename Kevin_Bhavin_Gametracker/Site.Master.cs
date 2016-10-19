using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kevin_Bhavin_Gametracker
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Page.Title + " loaded...");
            SetActivePage();


        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Games":
                    Games.Attributes.Add("class", "active");
                    break;
                case "Register":
                    Register.Attributes.Add("class", "active");
                    break;
                case "Login":
                    Login.Attributes.Add("class", "active");
                    break;
            }
            checkloginlogout();
        }

        public void checkloginlogout()
        {
            if (System.Web.HttpContext.Current.User != null && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Login.Visible = false;
                Logout.Visible = true;
                CurrentUserText.Visible = true;
                CurrentUserText.Text = "Current User: " + System.Web.HttpContext.Current.User.Identity.Name.ToString();
                System.Diagnostics.Debug.WriteLine("Logged in User!");
            }
            else
            {
                CurrentUserText.Visible = false;
                Logout.Visible = false;
                Login.Visible = true;
            }
        }
    }
}