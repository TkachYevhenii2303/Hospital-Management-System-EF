using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class HasRoles : BaseEntity
    {
        public Employees Employees { get; set; } = default!;

        public Guid EmployeesId { get; set; }

        public Positions Roles { get; set; } = null!;

        public Guid RolesId { get; set; }
    }
}
