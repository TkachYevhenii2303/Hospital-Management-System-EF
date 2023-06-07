using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Pagination
{
    public class Response<TEntity>
    {
        public TEntity? Result { get; set; }

        public bool Succeeded { get; set; } = true;
        
        public string[] Errors { get; set; } = new string[0];
        
        public string Message { get; set; } = string.Empty;
    }
}
