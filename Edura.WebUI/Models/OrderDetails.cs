using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage ="Lütfen Bir Adress Tanımı Giriniz")]
        public string adresTanimi { get; set; }
        [Required(ErrorMessage = "Lütfen Bir Adres Tanımi giriniz")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Lütfen Bir Şehir Tanımı giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen bir Semt Tanımı giriniz")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen bir Telefon numarası Giriniz")]
        public string Telefon { get; set; }
    }
}
