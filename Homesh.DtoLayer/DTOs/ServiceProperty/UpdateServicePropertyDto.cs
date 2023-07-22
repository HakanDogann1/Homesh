using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DtoLayer.DTOs.ServiceProperty
{
    public class UpdateServicePropertyDto
    {
        public string ID { get; set; }
        public string ServicePropertyTitle { get; set; }
        public string ServicePropertyDescription { get; set; }
        public double ServicePropertyPrice { get; set; }
        public string ServicePropertyImage { get; set; }
    }
}
