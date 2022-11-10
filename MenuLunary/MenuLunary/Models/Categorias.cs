using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuLunary.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string? RESTACATEGORIA { get; set; }
    }
}
