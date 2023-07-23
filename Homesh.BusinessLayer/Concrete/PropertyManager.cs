using Homish.BusinessLayer.Abstract;
using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.BusinessLayer.Concrete
{
    public class PropertyManager:IPropertyService
    {
        private readonly IPropertyDal _propertyDal;

        public PropertyManager(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public void TAdd(Property entity)
        {
            _propertyDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _propertyDal.Delete(id);
        }

        public List<Property> TGetAll()
        {
            return _propertyDal.GetAll();
        }

        public Property TGetById(string id)
        {
            return _propertyDal.GetById(id);
        }

        public void TUpdate(Property entity)
        {
            _propertyDal.Update(entity);
        }
    }
}
