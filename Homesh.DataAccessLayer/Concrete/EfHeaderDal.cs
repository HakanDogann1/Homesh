using Homesh.DataAccessLayer.Abstract;
using Homesh.DataAccessLayer.Repository;
using Homesh.DataAccessLayer.Settings.Abstract;
using Homesh.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.DataAccessLayer.Concrete
{
    public class EfHeaderDal : GenericRepository<Header>, IHeaderDal
    {
        public EfHeaderDal(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
