using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Shedules : BaseEntity
    {
        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public InDepartment InDepartment { get; set; } = null!; 

        public Guid InDepartmentsId { get; set; }
    }
}
