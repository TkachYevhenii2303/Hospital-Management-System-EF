using Hospital_Management_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class AppointmentsStatus : BaseEntity
    {
        public AppointmentsStatusTypesEnum StatusTitle { get; set; } = AppointmentsStatusTypesEnum.None;

        public ICollection<StatusHistories> StatusHistories { get; set; } = null!;
    }
}
