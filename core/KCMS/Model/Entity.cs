using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KCMS.Model
{
    public abstract class Entity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
