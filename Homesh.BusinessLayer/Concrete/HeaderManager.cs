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
    public class HeaderManager:IHeaderService
    {
        private readonly IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public void TAdd(Header entity)
        {
            _headerDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _headerDal.Delete(id);
        }

        public List<Header> TGetAll()
        {
            return _headerDal.GetAll();
        }

        public Header TGetById(string id)
        {
            return _headerDal.GetById(id);
        }

        public void TUpdate(Header entity)
        {
            _headerDal.Update(entity);
        }
    }
}
