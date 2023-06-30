using Domain.Entities;
using Domain.Requests;

namespace Service.Contracts
{
    public interface IUsuarioService
    {
        Task<Usuario?> Consultar(int idUsuario);

        Task<bool> Incluir(Usuario request);

        Task<bool> Alterar(Usuario request);

        Task<bool> Deletar(int idUsuario);

        Task<bool> Login(UsuarioLoginRequest request);
    }
}
