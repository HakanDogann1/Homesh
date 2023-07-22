using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DtoLayer.DTOs.Service
{
    public class UpdateServiceDto
    {
        public string ID { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }
}
