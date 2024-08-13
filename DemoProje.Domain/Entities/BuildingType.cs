using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProje.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class BuildingType
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } = String.Empty;
        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;

       

    }
}
