using MusicStore.Models;
using MusicStore.Models.Login;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MusicStore.Migrations
{
    internal partial class UserConfiguration : DbMigrationsConfiguration<MusicStore.Models.Login.AppDbContext>
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