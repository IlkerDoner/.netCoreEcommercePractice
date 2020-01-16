using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int itemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / itemsPerPage);
        }

        public class ProductListModel
        {
            public IEnumerable<Product> Products { get; set; }
            public PagingInfo pagingInfo { get; set; }

        }
    }
}
