using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace e_ticaret_web_razor_temp.Models
{
    public class Category
    {
            [Key]
            public int Id { get; set; }
            [Required]
            [MaxLength(30)]
            [DisplayName("Kategory Adı")]
            public string Name { get; set; }
            [DisplayName("Display Order")]
            [Range(1, 100, ErrorMessage = "Stoğa en az 1 en fazla 100 ürün koyabilirsiniz")]
            public int DisplayOrder { get; set; }
    }
}
