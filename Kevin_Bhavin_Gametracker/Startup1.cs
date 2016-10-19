using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//required for qwin startup
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(Kevin_Bhavin_Gametracker.Startup1))]

namespace Kevin_Bhavin_Gametracker
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            LoginPath = new PathString("/Login.aspx")
            });
        }
    }
}
