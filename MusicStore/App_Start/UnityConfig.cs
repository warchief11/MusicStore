using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using MusicStore.App_Start;
using MusicStore.DAL.Models;
using MusicStore.DAL.Models.User;
using System.Data.Entity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace MusicStore
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //container.RegisterType<MusicStoreContext>(new HierarchicalLifetimeManager());
            //container.RegisterType<DbContext, AppDbContext>();
            //container.RegisterType<AppUserManager>(new HierarchicalLifetimeManager());
            //container.RegisterType<AppSignInManager>(new HierarchicalLifetimeManager());
            //container.RegisterType<IUserStore<AppUser>, UserStore<AppUser>>(new HierarchicalLifetimeManager());
        }
    }
}