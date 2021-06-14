using Dapper;
using DevEvolucional.Core.DTOs;
using DevEvolucional.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvolucional.Infrastructure.Persistence.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly string _connectionString;
       
        public DisciplinaRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DevEvolucionalCs");
        }

        public async Task<List<DisciplinaDTO>> GetAllAsync()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Id, Descricao FROM Disciplina";

                var listaDisciplinas = await sqlConnection.QueryAsync<DisciplinaDTO>(script);

                return listaDisciplinas.ToList();
            }
        }
    }
}
