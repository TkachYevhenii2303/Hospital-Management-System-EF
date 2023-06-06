using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Context;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly HospitalManagementContext _context;

        public DetailsModel(HospitalManagementContext context)
        {
            _context = context;
        }

      public Employees Employees { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FirstOrDefaultAsync(m => m.ID == id);

            if (employees == null)
            {
                return NotFound();
            }
            else 
            {
                Employees = employees;
            }
            return Page();
        }
    }
}
