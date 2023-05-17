using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Departments : BaseEntity
    {
        public string DepartmentTitle { get; set; } = string.Empty;

        public Hospitals Hospital { get; set; } = null!;

        public Guid HospitalId { get; set; }

        public ICollection<InDepartments> InDepartments { get; set; } = null!;
    }
}
