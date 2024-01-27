using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        public string category { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public string image_file { get; set; }
        public decimal price { get; set; }
    }
}