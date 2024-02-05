using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ShopWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Unikalny identyfikator")]
        public string ISBN { get; set; }
        [Required]
        [Display(Name = "Reżyser")]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Cena katalogowa")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Cena od 1-50")]
        [Range(1, 1000)]
        public double Price { get; set; }


        [Required]
        [Display(Name = "Cena od 50+")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Cena od 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]    
        public Category Category { get; set; }
        [ValidateNever]
        [Display(Name = "Zdjęcie okładki")]
        public List<ProductImage> ProductImages { get; set; }

    }
}
