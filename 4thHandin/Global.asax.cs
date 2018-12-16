using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace _4Handin
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            _4thHandin.RouteConfig.RegisterRoutes(RouteTable.Routes);
            _4thHandin.BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}