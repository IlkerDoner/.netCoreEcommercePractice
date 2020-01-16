using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Entity;
using Edura.WebUI.Infrastructure;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IUnitOfWork unitOfWork;
       
        public CartController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int ProductId,int quantity =1)
        {
            var product = unitOfWork.Products.Get(ProductId);
            if (product !=null )
            {
                var cart = GetCart();
                cart.addProduct(product, quantity);
                SaveCart(cart);

            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int ProductId)
        {
            var product = unitOfWork.Products.Get(ProductId);
            if (product!=null)
            {
                var cart = GetCart(); // session daki Cart
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart(); // boş ise cart nesnesi yollayacak new onun ıcın yazıldı
        }

        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult CheckOut(OrderDetails model)
        {
            var cart = GetCart();
            if (cart.Products.Count == 0)
            {
                ModelState.AddModelError("Ürün Yok", "Sepetinizde Ürün Bulunmamaktadır");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(cart, model);
                cart.ClearAll();
                SaveCart(cart);
                return View("Completed");
            }
            return View(model);
        }

        private void SaveOrder(Cart cart, OrderDetails details)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(111111, 999999).ToString();
            order.Total = cart.TotalPrice();
            order.OrderDate = DateTime.Now;
            order.orderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;

            order.adresTanimi = details.adresTanimi;
            order.Adress = details.Adress;
            order.Sehir = details.Sehir;
            order.Semt = details.Semt;
            order.Telefon = details.Telefon;

            foreach (var product in cart.Products)
            {
                var orderline = new OrderLine();
                orderline.Quantity = product.Quantity;
                //orderline.Price = product.Quantity * product.Product.Price;
                orderline.Price = product.Product.Price; // adet zaten quantity de var 
                orderline.ProductId = product.Product.ProductId;
                order.orderLines.Add(orderline);

            }

            unitOfWork.Orders.Add(order);
            unitOfWork.SaveChanges();
        }
    }
}
