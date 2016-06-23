using MusicStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.DAL.Models;
using System.Threading;
using System.Collections;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace MusicStore.Tests.MockData
{
    public class FakeMusicStoreContext : IMusicStoreContext
    {
        public Dictionary<Type, object> _sets = new Dictionary<Type, object>();
        public List<object> Added = new List<object>();
        public List<object> Updated = new List<object>();
        public List<object> Removed = new List<object>();
        public bool Saved = false;

        public IQueryable<T> Query<T>() where T : class
        {
            return _sets[typeof(T)] as FakeDbSet<T>;
        }

        public void Dispose() { }

        public void AddSet<T>(IQueryable<T> objects) where T: class
        {
            var fakeDBSet = new FakeDbSet<T>();
            foreach (T item in objects)
            {
                fakeDBSet.Add(item);
            }
            _sets[typeof(T)] = fakeDBSet;
        }

        public void Add<T>(T entity) where T : class
        {
            Added.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            Updated.Add(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            Removed.Add(entity);
        }

        public void SaveChanges()
        {
            Saved = true;
        }



        public void RemoveRange<T>(IEnumerable<T> entity) where T : class
        {
            throw new NotImplementedException();
        }

        int IMusicStoreContext.SaveChanges()
        {
            Saved = true;
            return 1;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

