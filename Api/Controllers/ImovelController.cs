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
    public class ImovelController : ControllerBase
    {
        private readonly IImovelService _service;

        public ImovelController(IImovelService service)
        {
            _service = service;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Imovel>?>> Consultar()
            => await Uteis.VerificarRetornoNulo(await _service.Consultar());
    }
}
