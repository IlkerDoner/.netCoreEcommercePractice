using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Models
{
    public class CatalogListModel
    {
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }

    }
}
