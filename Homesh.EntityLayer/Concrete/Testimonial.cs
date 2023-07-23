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
    public class Testimonial: IMongoEntity
    {

        public string TestimonialNameSurname { get; set; }
        public string TestimonialDescription { get; set; }
    }
}
