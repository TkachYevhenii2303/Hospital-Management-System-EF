using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class HasRoles : BaseEntity
    {
        public Employees Employees { get; set; } = null!;

        public Guid EmployeesId { get; set; }

        public Roles Roles { get; set; } = null!;

        public Guid RolesId { get; set; }
    }
}
