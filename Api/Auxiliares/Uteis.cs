using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WEGGAPI.Auxiliares
{
    public static class Uteis
    {
        public static ActionResult VerificarRetornoNulo(object? resultado)
            => resultado == null
                ? new NotFoundObjectResult(Constantes.RegistroNaoEncontrado)
                : new OkObjectResult(resultado);
    }
}
