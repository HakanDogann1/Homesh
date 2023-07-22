using Homesh.EntityLayer.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.EntityLayer.Concrete
{
    public class Property: IMongoEntity
    {

        public string PropertyCountry { get; set; }
        public string PropertyDescription { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int PropertyCount { get; set; }
    }
}
