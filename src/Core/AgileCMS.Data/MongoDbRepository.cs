using AgileCMS.Domain;
using AgileCMS.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Data
{
    public class MongoDbRepository<T> : IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> Table => throw new NotImplementedException();

        public Task ClearAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(Expression<Func<T, bool>> filterexpression)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> InsertAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task Pull(string id, Expression<Func<T, IEnumerable<string>>> field, string element)
        {
            throw new NotImplementedException();
        }

        public Task PullFilter<U, Z>(string id, Expression<Func<T, IEnumerable<U>>> field, Expression<Func<U, Z>> elemFieldMatch, Z elemMatch)
        {
            throw new NotImplementedException();
        }

        public Task PullFilter<U>(string id, Expression<Func<T, IEnumerable<U>>> field, Expression<Func<U, bool>> elemFieldMatch)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> TableCollection(string collectionName)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> UpdateAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateField<U>(string id, Expression<Func<T, U>> expression, U value)
        {
            throw new NotImplementedException();
        }
    }
}
