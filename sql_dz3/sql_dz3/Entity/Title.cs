namespace Sql_dz3.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Title
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public List<Employee> Employee { get; set; } = new List<Employee>();
    }
}
