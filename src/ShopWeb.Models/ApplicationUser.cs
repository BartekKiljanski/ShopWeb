using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShopWeb.Models
{
    public class ApplicationUser: IdentityUser
    {
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
        [Display(Name = "ID firmy")]
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        [Display(Name = "Firma")]
        public Company? Company { get; set; }
        [NotMapped]
        [Display(Name = "Rola")]
        public string Role { get; set; }
    }
}
