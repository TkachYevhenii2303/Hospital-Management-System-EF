using Hospital_Management_System_DAL.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Pagination.Services.Interfaces
{
    public interface IUriService
    {
        Uri GetPageUri(PaginationFiltering filter, string route);
    }
}
