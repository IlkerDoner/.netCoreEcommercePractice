using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Entity
{
    public class Order
    {
        public Order()
        {
            orderLines = new List<OrderLine>(); // controller de de newleye biliriz orderLine ların null olmamasını saglar
        }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState orderState { get; set; }
        public string UserName { get; set; }

        public string adresTanimi { get; set; }

        public string Adress { get; set; }

        public string Sehir { get; set; }

        public string Semt { get; set; }

        public string Telefon { get; set; }

        public virtual List<OrderLine> orderLines { get; set; }
    }
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Tamamlandı")]
        Completed
    }
}
