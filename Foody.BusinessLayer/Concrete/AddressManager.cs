using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(Address entity)
        {
            _addressDal.Delete(entity);  
        }

        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();  
        }

        public Address TGetById(int id)
        {
            return _addressDal.GetById(id);  
        }

        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);  
        }

        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity); 
        }
    }
}
