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
	public class OrderHeader
	{


        public int Id { get; set; }
        [Display(Name = "ID aplikacji użytkownika")]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Data zamówienia")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Data wysyłki")]
        public DateTime ShippingDate { get; set; }
        [Display(Name = "Całkowita suma zamówienia")]
        public double OrderTotal { get; set; }
        [Display(Name = "Status zamówienia")]
        public string? OrderStatus { get; set; }
        [Display(Name = "Status płatności")]
        public string? PaymentStatus { get; set; }
        [Display(Name = "Numer śledzenia")]
        public string? TrackingNumber { get; set; }
        [Display(Name = "Przewoźnik")]
        public string? Carrier { get; set; }
        [Display(Name = "Data płatności")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Termin płatności")]
        public DateTime PaymentDueDate { get; set; }
        [Display(Name = "ID sesji")]
        public string? SessionId { get; set; }
        [Display(Name = "ID intencji płatności")]
        public string? PaymentIntentId { get; set; }
        [Display(Name = "Numer telefonu")]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Adres ulicy")]
        public string StreetAddress { get; set; }
        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Województwo")]
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }



    }
}
