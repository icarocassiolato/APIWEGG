using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Repository.Contracts;
using System.Data;

namespace Repository.Connection
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection() 
            => new MySqlConnection(_configuration.GetConnectionString("Padrao"));
    }
}
