using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DAL.Context;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeesServices _EmployeeService;

        private readonly HospitalManagementContext _context;

        public DeleteModel(IEmployeesServices employeeService, HospitalManagementContext context)
        {
            _EmployeeService = employeeService;

            _context = context;
        }

        [BindProperty]
        public Employees Employees { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var employees = await _context.Set<Employees>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == id);

            if (employees is null)
            {
                return NotFound();
            }
            else 
            {
                Employees = employees;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid id)
        {
            var employees = await _context.Set<Employees>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == id);

            if (employees is not null)
            {
                Employees = employees;

                _context.Set<Employees>().Remove(Employees);

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Employee");
        }
    }
}
