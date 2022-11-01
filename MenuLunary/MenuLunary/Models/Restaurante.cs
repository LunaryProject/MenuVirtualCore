using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuLunary.Models
{
    [Table("Restaurante")]
    public class Restaurante
    {
        [Column("id")]
        [Display(Name = "ID")]
        public int RESTAUID { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string RESTANOME { get; set; }
        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        [Column("Preço")]
        [Display(Name = "Preco")]
        public double RESTAPRECO { get; set; }

        [Column("Descrição")]
        [Display(Name = "Descricao")]
        public string RESTADESCRICAO { get; set; }
        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string RESTACATEGORIA { get; set; }
        [Column("")]
        [Display(Name = "imagem")]
        public byte[] imagem { get; set; }

        [Column("Oferta")]
        [Display(Name = "Oferta")]
        public bool Oferta { get; set; }

        [Column("Promoção")]
        [Display(Name = "Promocao")]
        public double RESTAPREPROMOCAO { get; set; }

        [Column("")]
        [Display(Name = "Disponibilidade")]
        public bool Disponibilidade { get; set; }
        [Column("Curtidas")]
        [Display(Name = "Curtidas")]
        public int Curtidas { get; set; }
    }
}
