using MusicStore.DAL.Models.User;
using System.Data.Entity.Migrations;

namespace MusicStore.DAL.Migrations
{
    public partial class UserConfiguration : DbMigrationsConfiguration<AppDbContext>
    {
        public UserConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AppDbContext context)
        {
            // Handle the historic orders load on a seperate thread, so the user can start using the app while this backfills historic orders.
            //ThreadPool.QueueUserWorkItem(x => AddOrders(context));
        }
    }
}