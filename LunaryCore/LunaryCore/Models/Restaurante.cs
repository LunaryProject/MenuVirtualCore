using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LunaryCore.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
        [Key]
        [Column("RESTAUID ")]
        [Display(Name = "RESTAUID ")]
        public int RESTAUID { get; set; }

        [Column("RESTANOME")]
        [Display(Name = "RESTANOME")]
        public string RESTANOME { get; set; }
        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        [Column("RESTAPRECO")]
        [Display(Name = "RESTAPRECO")]
        public double RESTAPRECO { get; set; }

        [Column("RESTADESCRICAO")]
        [Display(Name = "RESTADESCRICAO")]
        public string RESTADESCRICAO { get; set; }
        [Column("RESTACATEGORIA")]
        [Display(Name = "RESTACATEGORIA")]
        public string RESTACATEGORIA { get; set; }
        [Column("imagem")]
        [Display(Name = "imagem")]
        public byte[] imagem { get; set; }

        [Column("Oferta")]
        [Display(Name = "Oferta")]
        public bool Oferta { get; set; }

        [Column("RESTAPREPROMOCAO")]
        [Display(Name = "RESTAPREPROMOCAO")]
        public double RESTAPREPROMOCAO { get; set; }

        [Column("Disponibilidade")]
        [Display(Name = "Disponibilidade")]
        public bool Disponibilidade { get; set; }
        [Column("Curtidas")]
        [Display(Name = "Curtidas")]
        public int Curtidas { get; set; }
    }
}
