namespace SistemaDeCadastros.Models
{
    public class PratosModel
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
        public double RESTAPREPROMOCAO { get; set; }
        
        
    }
}
