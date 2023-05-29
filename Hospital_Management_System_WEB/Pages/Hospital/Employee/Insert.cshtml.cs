using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_Pages.Pages.Hospital.Employee
{
    public class InsertModel : PageModel
    {
        private readonly IEmployeesServices _employeesServices;

        public ResultResponse<IEnumerable<GetEmployeesDTO>> Employees { get; set; }

        public InsertModel(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;

            Employees = new ResultResponse<IEnumerable<GetEmployeesDTO>>();
        }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

        public async Task<ActionResult> OnPost(InsertEmployeeDTO employeeDTO)
        {
            var result = await _employeesServices.InsertEmployeeAsync(employeeDTO);

            if (result.Success)
            {
                return Redirect("~/");
            }
            else
            {
                ModelState.AddModelError(string.Empty, result.Message);

                return Page();
            }
        }
    }
}
