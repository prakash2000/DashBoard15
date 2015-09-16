using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DashBoard15.DAL;
using DashBoard15.Models;
using System.Data.Entity;

namespace DashBoard15
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Database.SetInitializer<AppContext>(new MyDbInitializer());
            Database.SetInitializer<AppContext>(new CreateDatabaseIfNotExists<AppContext>());
            AppContext context = new AppContext();
            context.Database.Initialize(true);
        }
    }
    //public class MyDbInitializer : CreateDatabaseIfNotExists<AppContext>
    //{

    //}
}