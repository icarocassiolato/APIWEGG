using Dapper;
using Repository.Contracts;
using Domain.Entities;

namespace Repository.Repositories
{
    public class CorretorRepository: ICorretorRepository
    {
        private readonly IConnectionFactory _conexao;
        public CorretorRepository(IConnectionFactory conexao)
        {
            _conexao = conexao;
        }

        public IEnumerable<Corretor>? Consultar()
        {
            using (var connectionDb = _conexao.Connection())
            {
                connectionDb.Open();
                return connectionDb.Query<Corretor>("SELECT * FROM Corretor");
            }
        }

        public Corretor? Consultar(int idCorretor)
        {
            using (var connectionDb = _conexao.Connection())
            {
                connectionDb.Open();
                return connectionDb.Query<Corretor>(
                    "SELECT * FROM Corretor WHERE idCorretor = @idCorretor",
                    new { idCorretor }).FirstOrDefault();
            }
        }

        public bool Incluir(Corretor request)
        {
            using (var connectionDb = _conexao.Connection())
            {
                connectionDb.Open();
                return connectionDb.Execute(
                    @"INSERT INTO Corretor
                    (Nome, RG, CPFCNPJ, Nascimento, ComissaoPadrao, Autonomo, Whatsapp)
                    VALUES
                    (@Nome, @RG, @CPFCNPJ, @Nascimento, @ComissaoPadrao, @Autonomo, @Whatsapp)",
                    request) > 0;
            }
        }
    
        public bool Alterar(Corretor request)
        {
            using (var connectionDb = _conexao.Connection())
            {
                connectionDb.Open();
                return connectionDb.Execute(
                    @"UPDATE Corretor
                    SET Nome = @Nome,
                    RG = @RG,
                    CPFCNPJ = @CPFCNPJ, 
                    Nascimento = @Nascimento, 
                    ComissaoPadrao = @ComissaoPadrao, 
                    Autonomo = @Autonomo, 
                    Whatsapp = @Whatsapp
                    WHERE idCorretor = @idCorretor",
                    request) > 0;
            }
        }
    
        public bool Deletar(int idCorretor)
        {
            using (var connectionDb = _conexao.Connection())
            {
                connectionDb.Open();
                return connectionDb.Execute(
                    @"DELETE 
                    FROM Corretor 
                    WHERE idCorretor = @idCorretor",
                    new { idCorretor }) > 0;
            }
        }
    }
}
