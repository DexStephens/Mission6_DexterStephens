using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_DexterStephens.Models.Home
{
    public class MovieModel
    {
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public int CategoryId {get; set;}
        public CategoryModel Category { get; set;}
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set;  }
        [Required]
        public string Rating { get; set; }  
        public bool Edited { get; set; }    
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

        public MovieModel() { }
    }
}
