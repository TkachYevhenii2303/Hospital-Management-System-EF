using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Hospitals : BaseEntity
    {
        public string HospitalTitle { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Details { get; set; } = string.Empty;

        public ICollection<Departments> Departments { get; set; } = null!;
    }
}
