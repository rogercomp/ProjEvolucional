using DevEvolucional.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Infrastructure.Persistence.Configurations
{
    public class DisciplinaConfigurations : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder
                .HasKey(s => s.Id);
        }
    }
}
