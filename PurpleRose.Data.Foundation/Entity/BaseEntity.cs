using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PurpleRose.Data.Foundation.Enum;
using System;

namespace PurpleRose.Data.Foundation.Entity
{
    public class BaseEntity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public EntityStatus Status { get; set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Local, Representation = BsonType.Int64)]
        public DateTime ModifiedDate { get; set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Local, Representation = BsonType.Int64)]
        public DateTime CreatedDate { get; set; }
    }
}
