using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_Pages.Pages.Hospital.Employee
{
    public class UpdateModel : PageModel
    {
        private readonly IEmployeesServices _employeesServices;

        [BindProperty]
        public ResultResponse<IEnumerable<UpdateEmployeeDTO>> Employee { get; set; }

        public UpdateModel(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;

            Employee = new ResultResponse<IEnumerable<UpdateEmployeeDTO>>();
        }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostUpdate(UpdateEmployeeDTO employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _employeesServices.UpdateEmployeeAsync(employee);

            if (result.Success)
            {
                return RedirectToPage("Main"); 
            }
            else
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return Page(); 
            }
        }
    }
}
