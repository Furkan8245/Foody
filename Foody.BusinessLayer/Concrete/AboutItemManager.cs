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
    public class AboutItemManager : IAboutItemService
    {
        private readonly IAboutItemDal _aboutItemDal;

        public AboutItemManager(IAboutItemDal aboutItemDal)
        {
            _aboutItemDal = aboutItemDal;
        }

        public void TDelete(int id)
        {
            _aboutItemDal.Delete(id);
        }

        public List<AboutItem> TGetAll()
        {
            return _aboutItemDal.GetAll();
        }

        public AboutItem TGetById(int id)
        {
            return _aboutItemDal.GetById(id);
        }

        public void TInsert(AboutItem entity)
        {
            _aboutItemDal.Insert(entity);
        
        }

        public void TUpdate(AboutItem entity)
        {
            _aboutItemDal.Update(entity);
        }
    }
}
