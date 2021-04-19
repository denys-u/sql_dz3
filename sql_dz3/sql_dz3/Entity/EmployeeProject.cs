namespace Sql_dz3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EmployeeProject
    {
        public int Id { get; set; }

        public decimal Rate { get; set; }

        public DateTime StartDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
