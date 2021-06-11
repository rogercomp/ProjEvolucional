using DevEvolucional.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Infrastructure.Persistence.Configurations
{
    public class AlunoDisciplinaConfigurations : IEntityTypeConfiguration<AlunoDisciplina>
    {
        public void Configure(EntityTypeBuilder<AlunoDisciplina> builder)
        {
            builder
                .HasKey(s => s.Id);
        }
    }
}
