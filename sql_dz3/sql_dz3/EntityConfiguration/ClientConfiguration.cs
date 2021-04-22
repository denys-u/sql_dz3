namespace Sql_dz3.EntityConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sql_dz3.Entity;

    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeId");
            builder.Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(20);
            builder.Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(20);
            builder.Property(p => p.PhoneNumber).IsRequired().HasColumnName("PhoneNumber").HasMaxLength(20);
            builder.Property(p => p.Email).IsRequired().HasColumnName("DateOfBirth").HasMaxLength(20);
        }
    }
}
