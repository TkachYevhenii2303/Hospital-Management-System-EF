using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly IEmployeesServices _EmployeeService;

        public CreateModel(IEmployeesServices employeeService)
        {
            _EmployeeService = employeeService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InsertEmployeeDTO EmployeeDTO { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            await _EmployeeService.InsertEmployeeAsync(EmployeeDTO);
            
            return RedirectToPage("Employee");
        }
    }
}
