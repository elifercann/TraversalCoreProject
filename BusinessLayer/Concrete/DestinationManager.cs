using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinatonDal;

        public DestinationManager(IDestinationDal destinatonDal)
        {
            _destinatonDal = destinatonDal;
        }

        public void TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _destinatonDal.GetById(id);
        }

        public List<Destination> TGetList()
        {
          return  _destinatonDal.GetList();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
