using Dapper;
using DevEvolucional.Core.Entities;
using DevEvolucional.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEvolucional.Infrastructure.Persistence.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly DevEvolucionalDbContext _dbContext;
        private readonly string _connectionString;
        public AlunoRepository(DevEvolucionalDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevEvolucionalCs");
        }
        public async Task<List<Aluno>> GetAllAsync()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<Aluno> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Alunos
                .Include(p => p.Disciplinas)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Aluno Aluno)
        {
            await _dbContext.Alunos.AddAsync(Aluno);
            await _dbContext.SaveChangesAsync();
        }


        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Aluno> GetByIdAsync(int id)
        {
            return await _dbContext.Alunos.SingleOrDefaultAsync(p => p.Id == id);
        }

    }
}