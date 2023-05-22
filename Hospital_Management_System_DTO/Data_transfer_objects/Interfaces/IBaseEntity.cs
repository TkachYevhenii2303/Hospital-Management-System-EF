using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DTO.Data_transfer_objects.Interfaces
{
    public interface IBaseEntity
    {
        public Guid ID { get; set; }
    }
}
