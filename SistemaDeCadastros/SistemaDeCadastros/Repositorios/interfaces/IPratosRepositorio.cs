using SistemaDeCadastros.Models;

namespace SistemaDeCadastros.Repositorios.interfaces
{
    public interface IPratosRepositorio
    {
        Task<List<PratosModel>> BuscarTodosOsPratos();
        Task<PratosModel> BuscarPorId(int id);
        Task<PratosModel> Adicionar(PratosModel usuario);
        Task<PratosModel> Atualizar(PratosModel usuario,int id);
        Task<bool> Apagar(int id);
    }
}
