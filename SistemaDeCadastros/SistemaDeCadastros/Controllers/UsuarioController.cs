using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCadastros.Models;

namespace SistemaDeCadastros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<UsuarioModel>> BuscarTodosOsPratos()
        {
            return Ok();
        }
    }
}
