using Domain.Entities;
using Repository.Contracts;
using Service.Contracts;

namespace Service.Services
{
    public class CorretorService: ICorretorService
    {
        private readonly ICorretorRepository _repository;

        public CorretorService(ICorretorRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Corretor>? Consultar()
            => _repository.Consultar();

        public Corretor? Consultar(int idCorretor)
            => _repository.Consultar(idCorretor);

        public bool Incluir(Corretor request)
            => _repository.Incluir(request);
    
        public bool Alterar(Corretor request)
            => _repository.Alterar(request);
    
        public bool Deletar(int idCorretor)
            => _repository.Deletar(idCorretor);
    }
}
