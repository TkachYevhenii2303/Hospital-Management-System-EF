using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Filter;
using Hospital_Management_System_DAL.Generic_Repository_Pattern;
using Hospital_Management_System_DAL.Pagination;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Hospital_Management_System_DAL.Repositories.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;
using Microsoft.AspNetCore.Http;
using Hospital_Management_System_DAL.Helpers;

namespace Hospital_Management_System_DAL.Repositories
{
    internal class EmployeesRepository : GenericRepository<Employees>, IEmployeesRepository
    {
        private readonly HospitalContext _context;

        public EmployeesRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedResponse<IEnumerable<Employees>>> GetAllEmployeeUsingPaginationAsync([FromQuery] PaginationFiltering filter, 
            IUriService uriService, 
            string route)
        {
            var validFilter = new PaginationFiltering(filter.PageNumber, filter.PageSize);

            var pageResult = await _context.Employees
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(filter.PageSize)
                .AsNoTracking().ToListAsync();

            var totalRecords = await _context.Employees.CountAsync();
            var pagedReponse = PaginationHelper.CreatePagedReponse<Employees>(pageResult, validFilter, totalRecords, uriService, route);

            return pagedReponse;
        }
    }
}
