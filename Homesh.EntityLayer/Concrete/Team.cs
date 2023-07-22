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
    public class Team: IMongoEntity
    {

        public string TeamName { get; set; }
        public string TeamDepartment { get; set; }
        public string TeamImage { get; set; }
    }
}
