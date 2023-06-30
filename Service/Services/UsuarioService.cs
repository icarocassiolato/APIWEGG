using Domain.Entities;
using Domain.Requests;
using Repository.Contracts;
using Service.Contracts;

namespace Service.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<Usuario?> Consultar(int idUsuario)
            => await _repository.Consultar(idUsuario);

        public async Task<bool> Incluir(Usuario request)
            => await _repository.Incluir(request);
    
        public async Task<bool> Alterar(Usuario request)
            => await _repository.Alterar(request);
    
        public async Task<bool> Deletar(int idUsuario)
            => await _repository.Deletar(idUsuario);

        public async Task<bool> Login(UsuarioLoginRequest request)
            => await _repository.Login(request);
    }
}
