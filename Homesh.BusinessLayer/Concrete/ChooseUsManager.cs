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
    public class ChooseUsManager : IChooseUsService
    {
        private readonly IChooseUsDal _chooseUsDal;

        public ChooseUsManager(IChooseUsDal chooseUsDal)
        {
            _chooseUsDal = chooseUsDal;
        }

        public void TAdd(ChooseUs entity)
        {
            _chooseUsDal.Add(entity);
        }

        public void TDelete(string id)
        {
             _chooseUsDal.Delete(id);
        }

        public List<ChooseUs> TGetAll()
        {
            return _chooseUsDal.GetAll();
        }

        public ChooseUs TGetById(string id)
        {
            return _chooseUsDal.GetById(id);
        }

        public void TUpdate(ChooseUs entity)
        {
            _chooseUsDal.Update(entity);
        }
    }
}
