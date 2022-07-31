using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.core.Entities
{
   public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string? EmployeeName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int DepartmentId { get; set; }
        public ulong Phone { get; set; }
        public string? Email { get; set; }
        public int Salary { get; set; }
    }
}
