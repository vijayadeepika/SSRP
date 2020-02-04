using Password_Reset.App_Start;
using Password_Reset.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebMatrix.WebData;

namespace Password_Reset
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

        }
    }

    public class SimpleMembershipInitializer
    {
        //public SimpleMembershipInitializer()
        //{
        //    using (var context = new UsersContext())
        //        context.UserProfiles.Find(1);

        //    if (!WebSecurity.Initialized)
        //        WebSecurity.InitializeDatabaseConnection("DefaultConnection", "RegisterModel", "UserName", "Password", autoCreateTables: true);
            //if (!WebSecurity.Initialized)
            //    WebSecurity.InitializeDatabaseConnection("DefaultConnection", "RegisterModel", "UserName",autoCreateTables:true);
       // }
    }
}
