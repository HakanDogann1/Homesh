using Homish.EntityLayer.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Homish.EntityLayer.Concrete
{
    public class ChooseUs: IMongoEntity
    {
  
        public string ChooseUsTitle { get; set; }
        public string ChooseUsDescription { get; set; }
    }
}
