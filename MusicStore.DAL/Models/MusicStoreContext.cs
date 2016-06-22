using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicStore.DAL.Models
{
    public class MusicStoreContext : DbContext, IMusicStoreContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }

        void IMusicStoreContext.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }

        void IMusicStoreContext.Update<T>(T entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        void IMusicStoreContext.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }

        void IMusicStoreContext.RemoveRange<T>(IEnumerable<T> entity)
        {
            Set<T>().RemoveRange(entity);
        }
        int IMusicStoreContext.SaveChanges()
        {
            return SaveChanges();
        }

        Task<int> IMusicStoreContext.SaveChangesAsync()
        {
            return SaveChangesAsync();
        }

        Task<int> IMusicStoreContext.SaveChangesAsync(CancellationToken cancellationToken)
        {
            return SaveChangesAsync(cancellationToken);
        }
    }
}