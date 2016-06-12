using Microsoft.AspNet.Identity.EntityFramework;

namespace MusicStore.Models.Login
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("AppDbContext", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }
}