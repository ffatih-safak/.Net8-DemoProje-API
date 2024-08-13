using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DemoProje.Domain.Entities
{
    [BsonIgnoreExtraElements]
    public class Building
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } = String.Empty;
        [BsonElement("buildingTypeId")]
        public string BuildingTypeId { get; set; } = String.Empty;
        [BsonElement("buildingType")]
        public string BuildingType { get; set; } = String.Empty;
        [BsonElement("buildingCost")]
        public decimal BuildingCost { get; set; } 
        [BsonElement("constructionTime")]
        public decimal ConstructionTime { get; set; }

    }
}
