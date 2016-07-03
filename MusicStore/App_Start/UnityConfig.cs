using Microsoft.Practices.Unity;
using MusicStore.DAL;
using MusicStore.DAL.Models;
using System.Web.Mvc;
using Unity.Mvc5;

namespace MusicStore
{
    public static class UnityConfig
    {
        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IMusicStoreContext, MusicStoreContext>(new HierarchicalLifetimeManager());
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //container.RegisterType<MusicStoreContext>(new HierarchicalLifetimeManager());
            //container.RegisterType<DbContext, AppDbContext>();
            //container.RegisterType<AppUserManager>(new HierarchicalLifetimeManager());
            //container.RegisterType<AppSignInManager>(new HierarchicalLifetimeManager());
            //container.RegisterType<IUserStore<AppUser>, UserStore<AppUser>>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}