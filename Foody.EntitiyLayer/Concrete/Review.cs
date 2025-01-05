using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntitiyLayer.Concrete
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string Comment  { get; set; }
        public string ImageUrl  { get; set; }
    }
}
