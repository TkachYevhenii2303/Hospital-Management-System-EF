using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_Pages.Pages.Hospital.Employee
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeesServices _employeesServices;

        public DeleteModel(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;
        }

        public async Task<ActionResult> OnGetAsync(Guid ID)
        {
            await _employeesServices.DeleteEntityByIdAsync(ID);

            return RedirectToPage("Main");
        }
    }
}
