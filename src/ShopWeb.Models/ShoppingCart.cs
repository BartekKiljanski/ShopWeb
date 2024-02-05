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
    public class ShoppingCart {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        [Display(Name = "Produkt")]
        public Product Product { get; set; }
        [Range(1, 1000, ErrorMessage = "Proszę wprowadzić wartość pomiędzy 1 a 1000")]
        [Display(Name = "Liczba")]
        public int Count { get; set; }
        [Display(Name = "ID aplikacji użytkownika")]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        [Display(Name = "Aplikacja użytkownika")]
        public ApplicationUser ApplicationUser { get; set; }

		[NotMapped]
        [Display(Name = "Cena")]
        public double Price { get; set; }
	}
}
