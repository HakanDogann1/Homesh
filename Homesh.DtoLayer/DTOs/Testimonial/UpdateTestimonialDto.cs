using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DtoLayer.DTOs.Testimonial
{
    public class UpdateTestimonialDto
    {
        public string ID { get; set; }
        public string TestimonialNameSurname { get; set; }
        public string TestimonialDescription { get; set; }
    }
}
