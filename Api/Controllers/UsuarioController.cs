using Domain.Entities;
using Domain.Requests;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using WEGGAPI.Auxiliares;

namespace Api.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet("{idUsuario}")]
        public async Task<ActionResult<Usuario?>> Consultar(int idUsuario)
            => await Uteis.VerificarRetornoNulo(await _service.Consultar(idUsuario));

        [HttpPost()]
        public async Task<ActionResult<bool>> Incluir(UsuarioIncluirRequest request)
            => Ok(await _service.Incluir(request)); 
    
        [HttpPut()]
        public async Task<ActionResult<bool>> Alterar(Usuario request)
            => Ok(await _service.Alterar(request)); 
    
        [HttpDelete("{idUsuario}")]
        public async Task<ActionResult<bool>> Deletar(int idUsuario)
            => Ok(await _service.Deletar(idUsuario));

        [HttpPost("Login")]
        public async Task<ActionResult<bool>> Login(UsuarioLoginRequest request)
            => Ok(await _service.Login(request));

    }
}
