using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts :ViewComponent
    {
        private IProductRepository productRepository;

        public FeaturedProducts(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public IViewComponentResult Invoke ()
        {
            return View(productRepository.GetAll().Where(i => i.IsApproved && i.IsFeatured).ToList());
        }
    }
}
