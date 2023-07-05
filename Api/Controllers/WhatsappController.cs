using Domain.Requests;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Api.Controllers
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/[controller]")]
    [ApiController]
    public class WhatsappController : ControllerBase
    {
        private readonly IWhatsappService _service;

        public WhatsappController(IWhatsappService service)
        {
            _service = service;
        }

        [HttpPost()]
        public async Task<ActionResult<bool>> EnviarMensagem(WhatsappEnviarMensagemRequest request)
            => Ok(await _service.EnviarMensagem(request)); 
    }
}
