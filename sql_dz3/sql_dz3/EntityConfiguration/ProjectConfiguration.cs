namespace Sql_dz3.EntityConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sql_dz3.Entity;

    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ProjectId");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnName("Budget").HasColumnType("money");
            builder.Property(p => p.StartDate).HasColumnName("StartDate").HasColumnType("date");
            builder.Property(p => p.EndDate).HasColumnName("EndDate").HasColumnType("date");
        }
    }
}
