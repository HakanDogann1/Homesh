using Homish.EntityLayer.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.EntityLayer.Concrete
{
    public class ServiceProperty: IMongoEntity
    {
 
        public string ServicePropertyTitle { get; set; }
        public string ServicePropertyDescription { get; set; }
        public double ServicePropertyPrice { get; set; }
        public string ServicePropertyImage { get; set; }
    }
}
