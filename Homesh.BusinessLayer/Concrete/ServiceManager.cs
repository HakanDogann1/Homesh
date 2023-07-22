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
    public class ServiceManager:IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _serviceDal.Delete(id);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service TGetById(string id)
        {
            return _serviceDal.GetById(id);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
