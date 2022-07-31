using Project_Management.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.core.Contract
{
   public interface IProjectManagementReport
    {
      //  public List<Assignment> GetAssignments();
        public List<Department> GetDepartments();
        public List<Employee> GetEmployees();
        public List<Project> GetProjects();
    }
}
