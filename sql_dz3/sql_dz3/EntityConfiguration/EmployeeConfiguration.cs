namespace Sql_dz3.EntityConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sql_dz3.Entity;

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("EmployeeId");
            builder.Property(p => p.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate").HasColumnType("datetime2");
            builder.Property(p => p.DateOfBirth).IsRequired().HasColumnName("DateOfBirth").HasColumnType("datetime2");

            builder.HasOne(d => d.Office)
                .WithMany(p => p.Employee)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Title)
                .WithMany(p => p.Employee)
                .HasForeignKey(b => b.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
