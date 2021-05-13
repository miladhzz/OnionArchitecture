using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory.Generics.Infrastructure
{
    public class BaseRepository<TKey, T> : IRepository<TKey, T> where T : DomainBase<TKey>
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
            Save();
        }

        public bool Exist(string model)
        {
            throw new NotImplementedException();
        }

        public T Get(TKey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
