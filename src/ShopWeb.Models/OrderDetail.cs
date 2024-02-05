using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Models
{
    public class OrderDetail {
        public int Id { get; set; }
        [Required]
        [Display(Name = "ID zamówienia")]
        public int OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        [ValidateNever]
        [Display(Name = "Zamówienie")]
        public OrderHeader OrderHeader { get; set; }


        [Required]
        [Display(Name = "ID produktu")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        [Display(Name = "Produkt")]
        public Product Product { get; set; }
        [Display(Name = "Ilość")]
        public int Count { get; set; }
        [Display(Name = "Cena")]
        public double Price { get; set; }

    }
}
