using Homesh.BusinessLayer.Abstract;
using Homesh.DataAccessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.BusinessLayer.Concrete
{
    public class ServicePropertyManager:IServicePropertyService
    {
        private readonly IServicePropertyDal _servicePropertyDal;

        public ServicePropertyManager(IServicePropertyDal servicePropertyDal)
        {
            _servicePropertyDal = servicePropertyDal;
        }

        public void TAdd(ServiceProperty entity)
        {
            _servicePropertyDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _servicePropertyDal.Delete(id);
        }

        public List<ServiceProperty> TGetAll()
        {
            return _servicePropertyDal.GetAll();
        }

        public ServiceProperty TGetById(string id)
        {
            return _servicePropertyDal.GetById(id);
        }

        public void TUpdate(ServiceProperty entity)
        {
            _servicePropertyDal.Update(entity);
        }
    }
}
