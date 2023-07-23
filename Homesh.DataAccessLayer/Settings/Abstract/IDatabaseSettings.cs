using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Settings.Abstract
{
    public interface IDatabaseSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string  ChooseUseCollectionName{ get; set; }
        public string  ContactCollectionName{ get; set; }
        public string  HeaderCollectionName{ get; set; }
        public string  PlanCollectionName{ get; set; }
        public string  PropertyCollectionName{ get; set; }
        public string  ServiceCollectionName{ get; set; }
        public string  ServicePropertyCollectionName{ get; set; }
        public string  TeamCollectionName{ get; set; }
        public string  TestimonialCollectionName{ get; set; }
    }
}
