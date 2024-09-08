using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Salary { get; set; }
    }

    //[Table("Managers")]
    public class Manager : Employee
    {
        public string? Department { get; set; }
    }

    //[Table("Developers")]
    public class Developer : Employee
    {
        public string? Language { get; set; }
    }
}
