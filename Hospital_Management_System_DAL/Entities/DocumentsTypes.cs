using Hospital_Management_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Entities
{
    public class DocumentsTypes : BaseEntity
    {
        public DocumentsTypesEnum TypesTitle { get; set; } = DocumentsTypesEnum.None;

        public ICollection<Documents> Documents { get; set; } = null!;
    }
}
