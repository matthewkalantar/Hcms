using AgileCMS.Domain;
using AgileCMS.Domain.Data;
using MongoDB.Driver;
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
        #region Fields
        protected IMongoCollection<T> _mongoCollection;

        /// <summary>
        /// Gets the collection
        /// </summary>
        public IMongoCollection<T> MongoCollection
        {
            get
            {
                return _mongoCollection;
            }
        }

        /// <summary>
        /// MongoDb Database
        /// </summary>
        protected IMongoDatabase _database;
        public IMongoDatabase Database
        {
            get
            {
                return _database;
            }
        }
        #endregion

        #region Ctor

        /// <summary>
        /// Constructor
        /// </summary>        
        public MongoDbRepository()
        {
            var connection = DataSettingsManager.LoadSettings();

            if (!string.IsNullOrEmpty(connection.ConnectionString))
            {
                var client = new MongoClient(connection.ConnectionString);
                var DbNameName = new MongoUrl(connection.ConnectionString).DatabaseName;
                _database = client.GetDatabase(DbNameName);
                _mongoCollection = _database.GetCollection<T>(typeof(T).Name);
            }

        }
        #endregion

        #region Methods
        /// <summary>
        /// Clear entities
        /// </summary>
        public virtual Task ClearAsync()
        {
            return _mongoCollection.DeleteManyAsync(Builders<T>.Filter.Empty);
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual void Delete(T entity)
        {
            _mongoCollection.FindOneAndDelete(e => e.Id == entity.Id);
        }

        /// <summary>
        /// Delete entities (Bulk)
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Delete(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                _mongoCollection.FindOneAndDeleteAsync(e => e.Id == entity.Id);
            }
        }

        /// <summary>
        /// Async Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual async Task<T> DeleteAsync(T entity)
        {
            await _mongoCollection.DeleteOneAsync(e => e.Id == entity.Id);
            return entity;
        }

        /// <summary>
        /// Async Delete entities (Bulk)
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                await DeleteAsync(entity);
            }
            return entities;
        }

        /// <summary>
        /// Async Delete many entities
        /// </summary>
        /// <param name="filterexpression"></param>
        /// <returns></returns>
        public virtual async Task DeleteManyAsync(Expression<Func<T, bool>> filterexpression)
        {
            await _mongoCollection.DeleteManyAsync(filterexpression);
        }

        /// <summary>
        /// Get all entities in collection
        /// </summary>
        /// <returns>collection of entities</returns>
        public virtual Task<List<T>> GetAllAsync()
        {
            return  _mongoCollection.AsQueryable().ToListAsync();
        }


        /// <summary>
        /// Get entity by Id
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual T GetById(string id)
        {
            return _mongoCollection.Find(e => e.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Get Async entity by Id
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        public virtual Task<T> GetByIdAsync(string id)
        {
            return _mongoCollection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual T Insert(T entity)
        {
            _mongoCollection.InsertOne(entity);
            return entity;
        }

        /// <summary>
        /// Async Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public virtual async Task<T> InsertAsync(T entity)
        {
            await _mongoCollection.InsertOneAsync(entity);
            return entity;
        }

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Insert(IEnumerable<T> entities)
        {
            _mongoCollection.InsertMany(entities);
        }

        /// <summary>
        /// Async Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task<IEnumerable<T>> InsertAsync(IEnumerable<T> entities)
        {
            await _mongoCollection.InsertManyAsync(entities);
            return entities;
        }

        public virtual Task Pull(string id, Expression<Func<T, IEnumerable<string>>> field, string element)
        {
            throw new NotImplementedException();
        }

        public virtual Task PullFilter<U, Z>(string id, Expression<Func<T, IEnumerable<U>>> field, Expression<Func<U, Z>> elemFieldMatch, Z elemMatch)
        {
            throw new NotImplementedException();
        }

        public virtual Task PullFilter<U>(string id, Expression<Func<T, IEnumerable<U>>> field, Expression<Func<U, bool>> elemFieldMatch)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> TableCollection(string collectionName)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> UpdateAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateField<U>(string id, Expression<Func<T, U>> expression, U value)
        {
            throw new NotImplementedException();
        }
        public virtual IQueryable<T> Table => _mongoCollection.AsQueryable();
        #endregion
    }
}
