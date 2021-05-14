using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarFactory.Generics.Infrastructure
{
    public interface IRepository<TKey, T> where T : DomainBase<TKey>
    {
        void Create(T entity);
        List<T> GetAll();
        T Get(TKey id);
        void Save();
        bool Exist(Expression<Func<T, bool>> expression);
    }
}
