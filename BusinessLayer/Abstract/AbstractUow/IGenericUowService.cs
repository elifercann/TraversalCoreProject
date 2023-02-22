using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUow
{
    public interface IGenericUowService<T> 
    {
        void TInsert(T entity);
        void TMultiUpdate(List<T> t);
        void TUpdate(T entity);
        T TGetbyId(int id);
    }
}
