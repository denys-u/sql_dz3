using System;
using System.Collections.Generic;
using System.Text;

namespace Sql_dz3.Entity
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredDate { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
