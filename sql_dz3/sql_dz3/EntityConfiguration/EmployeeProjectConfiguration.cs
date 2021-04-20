﻿namespace Sql_dz3.EntityConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sql_dz3.Entity;

    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeProjectId");
            builder.Property(p => p.Rate).IsRequired().HasColumnName("Rate").HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2");
        }
    }
}
