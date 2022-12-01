using Microsoft.EntityFrameworkCore;
using SistemaDeCadastros.Data;
using SistemaDeCadastros.Models;
using SistemaDeCadastros.Repositorios.interfaces;

namespace SistemaDeCadastros.Repositorios
{
    public class Pratos : IPratosRepositorio
    {
        private readonly DbSistemas _dbContext;
        public Pratos(DbSistemas dbSistemas)
        {
            _dbContext = dbSistemas;
        }
        public async Task<PratosModel> BuscarPorId(int id)
        {
            return await _dbContext.Pratos.FirstOrDefaultAsync(x => x.RESTAUID == id);
        }

        public async Task<List<PratosModel>> BuscarTodosOsPratos()
        {
            return await _dbContext.Pratos.ToListAsync();
        }
        public async Task<PratosModel> Adicionar(PratosModel prato)
        {
            await _dbContext.Pratos.AddAsync(prato);
            await _dbContext.SaveChangesAsync();

            return prato;
        }

        public async Task<PratosModel> Atualizar(PratosModel prato, int id)
        {
            PratosModel pratosporid = await BuscarPorId(id);
            if (pratosporid == null)
            {
                throw new Exception($"Usuario para o Id:{id} não foi encontrado no banco dedos.");
            }
            pratosporid.RESTANOME = prato.RESTANOME;
            pratosporid.RESTAPRECO = prato.RESTAPRECO;
            pratosporid.RESTAUID = prato.RESTAUID;
            pratosporid.RESTACATEGORIA = prato.RESTACATEGORIA;
            pratosporid.RESTADESCRICAO = prato.RESTADESCRICAO;
            pratosporid.RESTAPREPROMOCAO = prato.RESTAPREPROMOCAO;

            _dbContext.Pratos.Update(pratosporid);
            await _dbContext.SaveChangesAsync();

            return pratosporid;
           
        }

        public async Task<bool> Apagar(int id)
        {
            PratosModel pratosporid = await BuscarPorId(id);
            if (pratosporid == null)
            {
                throw new Exception($"Usuario para o Id:{id} não foi encontrado no banco dedos.");
            }

            _dbContext.Pratos.Remove(pratosporid);
            await _dbContext.SaveChangesAsync();
            return true;
        }

       
    }
}
