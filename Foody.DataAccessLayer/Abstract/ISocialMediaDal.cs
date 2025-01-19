using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Abstract
{
    public interface ISocialMediaDal:IGenericDal<SocialMedia>
    {

        void Delete(int id);

    }
}
