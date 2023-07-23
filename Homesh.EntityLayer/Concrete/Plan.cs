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
    public class Plan: IMongoEntity
    {
 
        public string PlanPackage { get; set; }
        public double PlanPrice { get; set; }
        public string PlanDescription { get; set; }
        
    }
}
