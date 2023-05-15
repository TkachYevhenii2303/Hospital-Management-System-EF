using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Employees : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public bool ActiveIs { get; set; } = true;

        public ICollection<HasRoles> HasRoles { get; set; } = null!;    

        public ICollection<InDepartment> InDepartments { get; set; } = null!;
    }
}
