using DevEvolucional.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEvolucional.Core.Repositories
{
    public interface IAlunoRepository
    {
        Task<List<Aluno>> GetAllAsync();
        Task<Aluno> GetDetailsByIdAsync(int id);
        Task<Aluno> GetByIdAsync(int id);
        Task AddAsync(Aluno aluno);
        Task SaveChangesAsync();
    }
}
