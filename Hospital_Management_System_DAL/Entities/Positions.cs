using Hospital_Management_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Positions : BaseEntity
    {
        public string RolesTitle { get; set; } = string.Empty;

        public ICollection<HasRoles> HasRoles { get; set; } = null!;
    }
}
