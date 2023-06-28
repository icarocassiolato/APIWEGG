using Domain.Entities;

namespace Service.Contracts
{
    public interface ICorretorService
    {
        IEnumerable<Corretor>? Consultar();

        Corretor? Consultar(int idCorretor);
    
        bool Incluir(Corretor request);
    
        bool Alterar(Corretor request);
    
        bool Deletar(int idCorretor);
    }
}
