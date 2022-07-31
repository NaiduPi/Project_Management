using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.core.Entities
{
   public class Assignment
    {
        public int ProjectId { get; set; }
        public int EmployeeNumber { get; set; }
        public int HoursWorked { get; set; }

    }
}
