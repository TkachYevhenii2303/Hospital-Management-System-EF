using Hospital_Management_System_DTO.Data_transfer_objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO
{
    public class GetEmployeesDTO : IBaseEntity
    {
        public Guid ID { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;
    }
}
