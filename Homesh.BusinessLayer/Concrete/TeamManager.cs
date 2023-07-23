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
    public class TeamManager:ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void TAdd(Team entity)
        {
            _teamDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _teamDal.Delete(id);
        }

        public List<Team> TGetAll()
        {
            return _teamDal.GetAll();
        }

        public Team TGetById(string id)
        {
            return _teamDal.GetById(id);
        }

        public void TUpdate(Team entity)
        {
            _teamDal.Update(entity);
        }
    }
}
