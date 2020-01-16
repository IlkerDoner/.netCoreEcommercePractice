using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Models
{
    public class ProductDetailsModel
    {
        public Product  Product { get; set; }
        public List<Image> ProductImages { get; set; }
        public List<ProductAttribute> productAttributes { get; set; }
        public List<Category> categories { get; set; }

    }
}
