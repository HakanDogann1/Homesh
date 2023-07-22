﻿using Homesh.DataAccessLayer.Abstract;
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
    public class EfPropertyDal : GenericRepository<Property>, IPropertyDal
    {
        public EfPropertyDal(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
