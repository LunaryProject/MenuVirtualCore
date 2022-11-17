using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LunaryCore.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        [Column("RESTACATEGORIA")]
        [Display(Name = "RESTACATEGORIA")]
        public string RESTACATEGORIA { get; set; }
    }
}
