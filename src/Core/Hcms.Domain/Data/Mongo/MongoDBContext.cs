using MongoDB.Driver;

namespace Hcms.Domain.Data.Mongo
{
    public class MongoDBContext : IDatabaseContext
    {
        private string _connectionString;
        protected IMongoDatabase _database;
        public MongoDBContext()
        {
           
        }


        void IDatabaseContext.SetConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IDatabaseContext.Table<T>(string collectionName)
        {
            throw new NotImplementedException();
        }
    }
}
