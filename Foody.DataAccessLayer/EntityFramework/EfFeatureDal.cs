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
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(FoodyContext context) : base(context)
        {

        }

		public List<Feature> FeatureListByStatusTrue()
		{
			var context = new FoodyContext();
			var values=context.Features.Where(x => x.Status == true).ToList();
			return values;
		}
	}
}
