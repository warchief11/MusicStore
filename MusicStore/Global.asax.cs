using MusicStore.DAL.Models;
using MusicStore.DAL.Models.User;
using System.Data.Entity;
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

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicStoreContext, DAL.Migrations.Configuration>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, DAL.Migrations.UserConfiguration>());

            using (var context = new MusicStore.DAL.Models.MusicStoreContext())
            {
                context.Database.Initialize(true);
            }
            using (var context = new AppDbContext())
            {
                context.Database.Initialize(true);
            }
            //Database.SetInitializer<MusicStore.DAL.Models.MusicStoreContext>(InitialCreate);
        }
    }
}