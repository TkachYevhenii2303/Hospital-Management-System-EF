using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class EmployeeModel : PageModel
    {
        private readonly IEmployeesServices _EmployeeService;

        public EmployeeModel(IEmployeesServices employeeService)
        {
            _EmployeeService = employeeService;
        }

        public ResultResponse<IEnumerable<GetEmployeesDTO>> EmployeesDTOs { get; set; }

        public async Task OnGet()
        {
            EmployeesDTOs = await _EmployeeService.GetAllEmployeesAsync();
        }
    }
}
