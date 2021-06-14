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

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _dbContext.Usuarios.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Usuario> GetUserByEmailAndPasswordAsync(string login, string passwordHash)
        {
            return await _dbContext
                .Usuarios
                .SingleOrDefaultAsync(u => u.Login == login && u.Senha == passwordHash);
        }
    }
}
