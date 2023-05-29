using Hospital_Management_System_API.Controllers;
using Hospital_Management_System_BLL.Services;
using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_Pages.Pages.Hospital.Employee
{
    public class MainModel : PageModel
    {
        private readonly IEmployeesServices _employeesServices;

        public ResultResponse<IEnumerable<GetEmployeesDTO>> Employees { get; set; }

        public MainModel(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;

            Employees = new ResultResponse<IEnumerable<GetEmployeesDTO>>();
        }

        public async Task<IActionResult> OnGet()
        {
            var result = await _employeesServices.GetAllEmployeesAsync();

            Employees.Result = result.Result;

            return Page();
        }
    }
}
