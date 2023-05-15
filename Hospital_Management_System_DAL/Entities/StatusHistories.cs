using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class StatusHistories : BaseEntity
    {
        public string Details { get; set; } = string.Empty;

        public Appointments Appointments { get; set; } = null!;

        public Guid AppointmentsId { get; set; }

        public AppointmentsStatus AppointmentsStatus { get; set; } = null!;

        public Guid AppointmentStatusId { get; set; }
    }
}
