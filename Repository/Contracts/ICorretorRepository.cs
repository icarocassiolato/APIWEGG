using Domain.Entities;

namespace Repository.Contracts
{
    public interface ICorretorRepository
    {
        public IEnumerable<Corretor>? Consultar();

        Corretor? Consultar(int idCorretor);
    
        bool Incluir(Corretor request);
    
        bool Alterar(Corretor request);
    
        bool Deletar(int idCorretor);
    }
}
