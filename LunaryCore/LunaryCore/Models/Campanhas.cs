using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LunaryCore.Models

{
    [Table("Campanhas")]
    public class Campanhas
    {
        [Key]
        [Column("CAMID")]
        [Display(Name = "CAMID")]
        public int CAMID { get; set; }
        [Column("CAMDESCRICAO")]
        [Display(Name = "CAMDESCRICAO")]
        public string CAMDESCRICAO { get; set; }
        [Column("CAMFOTO")]
        [Display(Name = "CAMFOTO")]
        public byte[] CAMFOTO { get; set; }
        [Column("CAMPRECO")]
        [Display(Name = "CAMPRECO")]
        public double CAMPRECO { get; set; }
    }
}
