using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Nazwa ulicy")]
        public string? StreetAddress { get; set; }
        [Display(Name = "Miasto")]
        public string? City { get; set; }
        [Display(Name = "Województwo")]
        public string? State { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string? PostalCode { get; set; }
        [Display(Name = "Numer telefonu")]
        public string? PhoneNumber { get; set; }
    }
}
