using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DtoLayer.DTOs.Plan
{
    public class AddPlanDto
    {
        public string PlanPackage { get; set; }
        public double PlanPrice { get; set; }
        public string PlanDescription { get; set; }
    }
}
