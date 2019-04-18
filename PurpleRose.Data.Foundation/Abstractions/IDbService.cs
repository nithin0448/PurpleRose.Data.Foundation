using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleRose.Data.Foundation.Abstractions
{
    public interface IDbService
    {
        IMongoDatabase GetDatabase();
    }
}
