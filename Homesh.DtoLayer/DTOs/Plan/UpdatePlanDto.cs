using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DtoLayer.DTOs.Plan
{
    public class UpdatePlanDto
    {
        public string ID { get; set; }
        public string PlanPackage { get; set; }
        public double PlanPrice { get; set; }
        public string PlanDescription { get; set; }
    }
}
