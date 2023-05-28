using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Filter;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using Hospital_Management_System_DAL.Pagination;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Repositories.Interfaces
{
    public interface IEmployeesRepository : IGenericRepository<Employees>
    {
        Task<PagedResponse<IEnumerable<Employees>>> GetAllEmployeeUsingPaginationAsync([FromQuery] PaginationFiltering filter, IUriService uriService, string route);  
    }
}
