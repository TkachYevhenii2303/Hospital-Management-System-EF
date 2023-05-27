using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO
{
    public abstract class BaseEntityDTO
    {
        public Guid ID { get; set; }
    }
}
