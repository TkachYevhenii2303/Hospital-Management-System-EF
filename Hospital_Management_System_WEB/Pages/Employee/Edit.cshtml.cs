using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using AutoMapper;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class EditModel : PageModel
    {
        private readonly IEmployeesServices _EmployeeService;

        private readonly IMapper _mapper;

        public EditModel(IEmployeesServices employeeService, IMapper mapper)
        {
            _EmployeeService = employeeService;

            _mapper = mapper;
        }

        [BindProperty]
        public ResultResponse<UpdateEmployeeDTO> UpdateEmployeeDTO { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var employees = await _EmployeeService.GetEmployeeByIdAsync(id);

            if (employees is null) { return NotFound(); }

            UpdateEmployeeDTO = _mapper.Map<ResultResponse<UpdateEmployeeDTO>>(employees);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }

            try
            {
                await _EmployeeService.UpdateEmployeeAsync(UpdateEmployeeDTO.Result);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (UpdateEmployeeDTO.Result is null) { return NotFound(); }
                
                else { throw; }
            }

            return RedirectToPage("Employee");
        }
    }
}
