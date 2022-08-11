using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Clients.Serializable
{

    public class Departments
    {
        public string lang { get; set; }
        public List<Department> departmentsList { get; set; }
    }

    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICommand SelectDepartmentServices { get => new Models.Commands.SelectDepartmentServices(); }
    }

}
