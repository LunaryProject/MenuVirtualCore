using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastros.Models;
using SistemaDeCadastros.Repositorios.interfaces;

namespace SistemaDeCadastros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosController : ControllerBase
    {
        private readonly IPratosRepositorio _pratosRepositorio;

        public PratosController(IPratosRepositorio pratosRepositorio)
        {
            _pratosRepositorio = pratosRepositorio;
        }

        [HttpGet]

        public async Task<ActionResult<List<PratosModel>>> BuscarTodosOsPratos()
        {
            List<PratosModel> pratos = await _pratosRepositorio.BuscarTodosOsPratos();
            return Ok(pratos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PratosModel>> BuscarporId(int id)
        {
            PratosModel pratos = await _pratosRepositorio.BuscarPorId(id);
            return Ok(pratos);
        }

        [HttpPost]

        public async Task<ActionResult<PratosModel>> Cadastrar([FromBody] PratosModel pratosModel)
        {
            PratosModel pratos = await _pratosRepositorio.Adicionar(pratosModel);
            return Ok(pratos);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<PratosModel>> Atualizar([FromBody] PratosModel pratosModel,int id)
        {
            pratosModel.RESTAUID = id;
            PratosModel pratos = await _pratosRepositorio.Atualizar(pratosModel,id);
            return Ok(pratos);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<PratosModel>> Apagar(int id)
        {
            bool apagado = await _pratosRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
