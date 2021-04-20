namespace Sql_dz3
{
    using System;
    using System.IO;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Sql_dz3.Entity;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsetting.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new ApplicationContext(options))
            {
                var employees = db.Employees.ToList();
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Id}.{employee.FirstName}.{employee.LastName}.{employee.DateOfBirth:dd/MM/yyyy} - {employee.HiredDate:dd/MM/yyyy}");
                }

                db.Employees.Add(new Employee() { HiredDate = DateTime.Today });
                db.SaveChanges();
            }

            Console.Read();
        }
    }
}
