using Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using WEGGAPI.Auxiliares;

namespace Api.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]")]
    [ApiController]
    public class CorretorController : ControllerBase
    {
        private readonly ICorretorService _service;

        public CorretorController(ICorretorService service)
        {
            _service = service;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Corretor>?>> Consultar()
            => await Uteis.VerificarRetornoNulo(await _service.Consultar());

        [HttpGet("{idCorretor}")]
        public async Task<ActionResult<Corretor?>> Consultar(int idCorretor)
            => await Uteis.VerificarRetornoNulo(await _service.Consultar(idCorretor));

        [HttpPost()]
        public async Task<ActionResult<bool>> Incluir(Corretor request)
            => Ok(await _service.Incluir(request)); 
    
        [HttpPut()]
        public async Task<ActionResult<bool>> Alterar(Corretor request)
            => Ok(await _service.Alterar(request)); 
    
        [HttpDelete("{idCorretor}")]
        public async Task<ActionResult<bool>> Deletar(int idCorretor)
            => Ok(await _service.Deletar(idCorretor)); 
    }
}
