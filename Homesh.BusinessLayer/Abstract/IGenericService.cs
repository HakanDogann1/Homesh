using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetAll();
        T TGetById(string id);
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(string id);
    }
}
