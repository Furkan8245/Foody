using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfSocialMedia : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMedia(FoodyContext context) : base(context)
        {
        }
    }
}
