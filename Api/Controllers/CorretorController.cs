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
        public ActionResult<IEnumerable<Corretor>?> Consultar()
            => Uteis.VerificarRetornoNulo(_service.Consultar());

        [HttpGet("{idCorretor}")]
        public ActionResult<Corretor?> Consultar(int idCorretor)
            => Uteis.VerificarRetornoNulo(_service.Consultar(idCorretor));

        [HttpPost()]
        public ActionResult<bool> Incluir(Corretor request)
            => Ok(_service.Incluir(request)); 
    
        [HttpPut()]
        public ActionResult<bool> Alterar(Corretor request)
            => Ok(_service.Alterar(request)); 
    
        [HttpDelete("{idCorretor}")]
        public ActionResult<bool> Deletar(int idCorretor)
            => Ok(_service.Deletar(idCorretor)); 
    }
}
