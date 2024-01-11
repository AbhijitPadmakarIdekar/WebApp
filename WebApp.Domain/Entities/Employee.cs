using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string FirstName { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(50)")]
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(50)")]
        public string? Department { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(50)")]
        public string? Address { get; set; } = string.Empty;

        public DateTime? HireDate { get; set; }
        public DateTime? DoB { get; set; }
        public DateTime? JoiningDate { get; set; }
        public float Salary { get; set; }
    }
}
