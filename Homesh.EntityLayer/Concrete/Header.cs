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
    public class Header: IMongoEntity
    {
   
        public string HeaderTitle1 { get; set; }
        public string HeaderTitle2 { get; set; }
    }
}
