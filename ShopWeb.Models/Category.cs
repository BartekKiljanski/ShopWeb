using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShopWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole Nazwa kategorii jest wymagane.")]
        [MaxLength(30, ErrorMessage = "Nazwa kategorii może zawierać maksymalnie 30 znaków.")]
        [DisplayName("Nazwa kategorii")]
        public string Name { get; set; }
        [DisplayName("Wyświetlana kolejność")]
        [Required(ErrorMessage = "Pole Wyświetlana kolejność jest wymagane.")]
        [Range(1, 100, ErrorMessage = "Wyświetlana kolejność musi mieścić się w przedziale 1-100.")]
        public int DisplayOrder { get; set; }
    }

}
