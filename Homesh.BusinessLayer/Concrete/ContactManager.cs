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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _contactDal.Delete(id);
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact TGetById(string id)
        {
            return _contactDal.GetById(id);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
