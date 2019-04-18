using MongoDB.Driver;
using PurpleRose.Data.Foundation.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleRose.Data.Foundation.MongoDb
{
    public class MongoClientFactory : IMongoClientFactory
    {
        private readonly MongoDBSettings mongoDbSettings;

        public MongoClientFactory(MongoDBSettings mongoDbSettings)
        {
            this.mongoDbSettings = mongoDbSettings;
        }

        private IMongoDatabase GetDatabase() =>
            new MongoClient(mongoDbSettings.DBConnectionString).GetDatabase(mongoDbSettings.DatabaseName);


        public IMongoCollection<T> GetCollection<T>() =>
            GetDatabase().GetCollection<T>(typeof(T).Name);


        public IMongoCollection<string> GetCollection(string nameOfCollection) =>
            GetDatabase().GetCollection<string>(nameOfCollection);
    }
}
