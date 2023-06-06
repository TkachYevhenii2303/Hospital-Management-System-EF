using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class InDepartments : BaseEntity
    {
        public DateTime TimeFrom { get; set; }

        public DateTime TimeTo { get; set; }

        public bool ActiveIs { get; set; } = true;

        public Employees Employees { get; set; } = default!;

        public Guid EmployeesId { get; set; }

        public Departments Departments { get; set; } = null!;   

        public Guid DepartmentsId { get; set; }

        public ICollection<Shedules> Shedules { get; set; } = null!;

        public ICollection<Documents> Documents { get; set; } = null!;

        public ICollection<Appointments> Appointments { get; set; } = null!;    
    }
}
