using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuLunary.Models
{
    [Table("Estabelicimento")]
    public class Estabelicimento
    {
        [Column("ID")]
        [Display(Name = "ID")]
        public int ESTABID { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string ESTABNOME { get; set; }

        [Column("Endereço")]
        [Display(Name = "Endereco")]
        public string ESTABENDERECO { get; set; }
        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string ESTABBAIRRO { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string ESTATELEFONE { get; set; }
        [Column("CEP")]
        [Display(Name = "CEP")]
        public string ESTABCEP { get; set; }
        [Column("Login")]
        [Display(Name = "Login")]
        public string ESTABLOGIN { get; set; }
        [Column("Senha")]
        [Display(Name = "Senha")]
        public string ESTABSENHA { get; set; }
        [Column("Tipo")]
        [Display(Name = "Tipo")]
        public string ESTATIPO { get; set; }
    }
}
