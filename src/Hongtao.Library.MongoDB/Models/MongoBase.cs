using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hongtao.Library.MongoDB.Models
{
    public class MongoBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }
    }
}