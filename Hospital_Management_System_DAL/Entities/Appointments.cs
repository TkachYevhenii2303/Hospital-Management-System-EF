using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class Appointments : BaseEntity
    {
        public DateTime AppointmentStartTime { get; set; }

        public DateTime AppointmentEndTtime { get; set; }

        public PatientsCases PatientsCases { get; set; } = null!;

        public Guid PatientCasesId { get; set; }

        public InDepartment InDepartment { get; set; } = null!;

        public Guid InDepartmentsId { get; set; }

        public ICollection<Documents> Documents { get; set; } = null!;

        public ICollection<StatusHistories> StatusHistories { get; set; } = null!;
    }
}
