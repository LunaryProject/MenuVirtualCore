namespace SistemaDeCadastros.Models
{
    public class UsuarioModel
    {
        public int RESTAUID { get; set; }
        public string? RESTANOME { get; set; }

        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public double RESTAPRECO { get; set; }
        public string? RESTADESCRICAO { get; set; }
        public string? RESTACATEGORIA { get; set; }
        public byte[]? imagem { get; set; }
        public bool Oferta { get; set; }
        public double RESTAPREPROMOCAO { get; set; }
        public bool Disponibilidade { get; set; }
        public int Curtidas { get; set; }
    }
}
