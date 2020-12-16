using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KCMS.Model
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
    }
}
