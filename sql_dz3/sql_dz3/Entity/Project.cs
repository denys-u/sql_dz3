using System;
using System.Collections.Generic;
using System.Text;

namespace Sql_dz3.Entity
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }
    }
}
