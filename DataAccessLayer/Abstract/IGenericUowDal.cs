using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericUowDal<T> where T:class
    {
        void Insert(T entity);
        void MultiUpdate(List<T> t);
        void Update(T entity);
        T GetById(int id);

    }
}
