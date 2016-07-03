using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MusicStore.DAL
{
    public interface IMusicStoreContext : IDisposable
    {
        //DbSet<Album> Albums { get; set; }
        //DbSet<Genre> Genres { get; set; }
        //DbSet<Artist> Artists { get; set; }
        //DbSet<CartItem> CartItems { get; set; }
        //DbSet<Order> Orders { get; set; }
        //DbSet<OrderDetail> OrderDetails { get; set; }

        IQueryable<T> Query<T>() where T : class;

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Remove<T>(T entity) where T : class;

        void RemoveRange<T>(IEnumerable<T> entity) where T : class;
        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}