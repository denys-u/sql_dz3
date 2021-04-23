namespace Sql_dz3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
