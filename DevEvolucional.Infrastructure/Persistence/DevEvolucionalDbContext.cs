using DevEvolucional.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevEvolucional.Infrastructure.Persistence
{
    public class DevEvolucionalDbContext : DbContext
    {
        public DevEvolucionalDbContext(DbContextOptions<DevEvolucionalDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunoDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
