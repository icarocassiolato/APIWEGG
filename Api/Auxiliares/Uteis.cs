using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WEGGAPI.Auxiliares
{
    public static class Uteis
    {        
        public static Task<ActionResult> VerificarRetornoNulo(object? resultado)
            => Task.FromResult<ActionResult>(resultado == null
                ? new NotFoundObjectResult(Constantes.RegistroNaoEncontrado)
                : new OkObjectResult(resultado));        
    }
}
