using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Filter;
using Hospital_Management_System_DAL.Pagination;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_Management_System_WEB.Pages.Employee
{
    public class EmployeeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public PaginationFiltering Filter { get; set; }

        private readonly IEmployeesServices _EmployeeService;
        private readonly IUriService _UriService;
        private readonly string _Route;

        public EmployeeModel(IEmployeesServices employeeService, IUriService uriService)
        {
            _EmployeeService = employeeService;
            _UriService = uriService;
            _Route = "/api/employees/Return_Employee_using_Pagination";
        }

        public PagedResponse<IEnumerable<GetEmployeesDTO>> EmployeesDTOs { get; set; }

        public async Task OnGet()
        {
            var validFilter = new PaginationFiltering(Filter.PageNumber, Filter.PageSize);

            EmployeesDTOs = await _EmployeeService.GetAllEmployeeUsingPaginationAsync(Filter, _UriService, _Route);
        }
    }
}
