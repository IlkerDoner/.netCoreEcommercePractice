using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Models
{
    public class Cart
    {
        private List<CartLine> products = new List<CartLine>();
        public List<CartLine> Products => products;


        public void addProduct(Product product, int quantity)
        {
            var prd = products
                .Where(i => i.Product.ProductId == product.ProductId)
                .FirstOrDefault();
            if (prd == null)
            {
                products.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }
        public void RemoveProduct(Product product)
        {
            products.RemoveAll(i => i.Product.ProductId == product.ProductId);
        }
        public double TotalPrice()
        {
            return products.Sum(i => i.Product.Price * i.Quantity);
        }
        public void ClearAll()
        {
            products.Clear();
        }
    }
    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product{ get; set; }
        public int Quantity { get; set; }






    }
}
