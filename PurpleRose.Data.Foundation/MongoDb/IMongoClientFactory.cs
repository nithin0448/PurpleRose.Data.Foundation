using MongoDB.Driver;

namespace PurpleRose.Data.Foundation.MongoDb
{
    public interface IMongoClientFactory
    {
        IMongoCollection<T> GetCollection<T>();
        IMongoCollection<string> GetCollection(string nameOfCollection);
    }
}
