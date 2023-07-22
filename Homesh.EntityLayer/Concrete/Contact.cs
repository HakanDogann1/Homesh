using Homesh.EntityLayer.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Homesh.EntityLayer.Concrete
{
    public class Contact: IMongoEntity
    {
   
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMessage { get; set; }
    }
}
