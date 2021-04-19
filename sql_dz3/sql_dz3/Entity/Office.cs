namespace Sql_dz3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Office
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public List<Employee> Employee { get; set; } = new List<Employee>();
    }
}
