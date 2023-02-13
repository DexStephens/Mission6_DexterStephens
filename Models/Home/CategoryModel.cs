using System.ComponentModel.DataAnnotations;

namespace Mission6_DexterStephens.Models.Home
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
