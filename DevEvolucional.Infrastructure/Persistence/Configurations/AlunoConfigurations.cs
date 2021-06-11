using DevEvolucional.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Infrastructure.Persistence.Configurations
{
    public class AlunoConfigurations : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasMany(u => u.Disciplinas)
                .WithOne()
                .HasForeignKey(u => u.IdDisciplina)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
