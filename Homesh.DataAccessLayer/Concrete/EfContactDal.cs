using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Repository;
using Homish.DataAccessLayer.Settings.Abstract;
using Homish.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Concrete
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
