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
    public class PlanManager:IPlanService
    {
        private readonly IPlanDal _planDal;

        public PlanManager(IPlanDal planDal)
        {
            _planDal = planDal;
        }

        public void TAdd(Plan entity)
        {
            _planDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _planDal.Delete(id);
        }

        public List<Plan> TGetAll()
        {
            return _planDal.GetAll();
        }

        public Plan TGetById(string id)
        {
            return _planDal.GetById(id);
        }

        public void TUpdate(Plan entity)
        {
            _planDal.Update(entity);
        }
    }
}
