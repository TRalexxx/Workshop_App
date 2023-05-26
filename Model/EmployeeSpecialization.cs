using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_App.Model
{
    internal class EmployeeSpecialization
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int Specialization_Id { get; set; }

        public EmployeeSpecialization(int id, int employeeId, int specializationId)
        {
            Id = id;
            Employee_Id = employeeId;
            Specialization_Id = specializationId;
        }
        public EmployeeSpecialization()  {  }

    }
}
