using MusicStore.Models;
using MusicStore.Models.Login;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityConfig.RegisterComponents();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicStoreContext, Migrations.Configuration>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.UserConfiguration>());
            using (var context = new MusicStoreContext())
            {
                context.Database.Initialize(true);
            }
            using (var context = new AppDbContext())
            {
                context.Database.Initialize(true);
            }
            //Database.SetInitializer<MusicStore.Models.MusicStoreContext>(InitialCreate);
        }
    }
}