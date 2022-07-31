using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.core.Entities
{
   public class Project
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public int DepartmentId { get; set; }
        public int MaxHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
