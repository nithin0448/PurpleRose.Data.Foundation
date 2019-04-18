using MongoDB.Driver;
using PurpleRose.Data.Foundation.Abstractions;
using PurpleRose.Data.Foundation.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleRose.Data.Foundation.Implementation
{
    class DbService : IDbService
    {
        private readonly IMongoDatabase database;
        private readonly IMongoClient mongoClient;
        private readonly MongoDBSettings dbSettings;

        public DbService(MongoDBSettings dbSettings)
        {
            this.dbSettings = dbSettings;
            mongoClient = new MongoClient(this.dbSettings.DBConnectionString);
            database = mongoClient.GetDatabase(this.dbSettings.DatabaseName);
        }

        public IMongoDatabase GetDatabase()
        {
            return database;
        }
    }
}
