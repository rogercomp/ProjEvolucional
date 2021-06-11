using DevEvolucional.Core.Entities;
using DevEvolucional.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEvolucional.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DevEvolucionalDbContext _dbContext;
        public UsuarioRepository(DevEvolucionalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aluno>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _dbContext.Usuarios.SingleOrDefaultAsync(u => u.Id == id);
        }

        public Task<Aluno> GetDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUserByEmailAndPasswordAsync(string login, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<Usuario> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        //{
        //    return await _dbContext
        //        .Users
        //        .SingleOrDefaultAsync(u => u.Email == email && u.Password == passwordHash);
        //}
    }
}
