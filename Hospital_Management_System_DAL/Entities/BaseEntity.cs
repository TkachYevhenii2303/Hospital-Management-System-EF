using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        public BaseEntity() { ID = Guid.NewGuid(); CreatedDateTime = DateTime.Now; UpdatedDateTime = null; }
    }
}
