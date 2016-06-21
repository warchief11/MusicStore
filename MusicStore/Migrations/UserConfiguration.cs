using MusicStore.DAL.Models;
using MusicStore.DAL.Models.User;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MusicStore.Migrations
{
    internal partial class UserConfiguration : DbMigrationsConfiguration<MusicStore.DAL.Models.User.AppDbContext>
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