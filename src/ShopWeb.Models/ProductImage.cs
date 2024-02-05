using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Models
{
    public class ProductImage {

        public int Id { get; set; }
        [Required]
        [Display(Name = "URL obrazu")]
        public string ImageUrl { get; set; }
        [Display(Name = "ID produktu")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [Display(Name = "Produkt")]
        public Product Product { get; set; }
    }
}
