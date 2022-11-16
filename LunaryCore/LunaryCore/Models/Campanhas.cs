using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LunaryCore.Models

{
    [Table("Campanhas")]
    public class Campanhas
    {
        [Key]
        [Column("ID")]
        [Display(Name = "ID")]
        public int CAMID { get; set; }
        [Column("Descrição")]
        [Display(Name = "Descricao")]
        public string CAMDESCRICAO { get; set; }
        [Column("Foto")]
        [Display(Name = "foto")]
        public byte[] CAMFOTO { get; set; }
        [Column("Preço")]
        [Display(Name = "Preco")]
        public double CAMPRECO { get; set; }
    }
}
