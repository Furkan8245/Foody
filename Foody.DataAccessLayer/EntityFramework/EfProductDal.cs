using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntitiyLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly FoodyContext _context; 
        public EfProductDal(FoodyContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            var values=_context.Products.Include(x=>x.Category).ToList(); 
            return values;
        }

        public List<Product> ProductListWithCategoryAndLast12Items()
        {
            var values = _context.Products.OrderByDescending(x => x.ProductId).Take(12).Include(y => y.Category).ToList();
            return values;
        }
    }
}
