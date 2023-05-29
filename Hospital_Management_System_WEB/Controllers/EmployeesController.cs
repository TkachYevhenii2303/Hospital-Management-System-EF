using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Filter;
using Hospital_Management_System_DAL.Fluent_Validation.Configurations;
using Hospital_Management_System_DAL.Pagination.Services.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace Hospital_Management_System_API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesServices _employeesServices;

        private readonly IUriService _uriService;

        public EmployeesController(IEmployeesServices employeesServices, IUriService uriService)
        {
            _employeesServices = employeesServices;

            _uriService = uriService;
        }

        /// <summary>
        /// Retrieves all employees asynchronously.
        /// </summary>
        /// <returns>An ActionResult containing a ResultResponse with an IEnumerable of GetEmployeesDTO.</returns>
        [HttpGet, Route("Return_all_Employee")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetEmployeesDTO>>>> GetAllEmployeesAsync()
        {
            var result = await _employeesServices.GetAllEmployeesAsync();
            
            return Ok(result);
        }

        /// <summary>
        /// Retrieves an employee asynchronously by their ID.
        /// </summary>
        /// <param name="ID">The ID of the employee to retrieve.</param>
        /// <returns>An ActionResult containing a ResultResponse with a GetEmployeesDTO.</returns>
        [HttpGet, Route("Return_Employee_ID/{ID}")]
        public async Task<ActionResult<ResultResponse<GetEmployeesDTO>>> GetEmployeeByIdAsync(Guid ID)
        {
            var result = await _employeesServices.GetEmployeeByIdAsync(ID);

            if (result.Result is null)
            {
                throw new KeyNotFoundException($"The element in a collection does not match any key in the collection!");
            }

            return Ok(result);       
        }

        /// <summary>
        /// Inserts a new employee asynchronously.
        /// </summary>
        /// <param name="employeeDTO">The data of the employee to insert.</param>
        /// <returns>An ActionResult containing a ResultResponse with a GetEmployeesDTO representing the inserted employee.</returns>
        [HttpPost, Route("Insert_Employee")]
        public async Task<ActionResult<ResultResponse<GetEmployeesDTO>>> InsertEmployeeAsync(InsertEmployeeDTO employeeDTO)
        {
            var result = await _employeesServices.InsertEmployeeAsync(employeeDTO);

            return Ok(result);
        }

        /// <summary>
        /// Updates an existing employee asynchronously.
        /// </summary>
        /// <param name="employeeDTO">The updated data of the employee.</param>
        /// <returns>An ActionResult containing a ResultResponse with a GetEmployeesDTO representing the updated employee.</returns>
        [HttpPut, Route("Update_Employee")]
        public async Task<ActionResult<ResultResponse<GetEmployeesDTO>>> UpdateEmployeeAsync(UpdateEmployeeDTO employeeDTO)
        {
            var result = await _employeesServices.UpdateEmployeeAsync(employeeDTO);

            return Ok(result);
        }

        /// <summary>
        /// Deletes an employee asynchronously by their ID.
        /// </summary>
        /// <param name="ID">The ID of the employee to delete.</param>
        /// <returns>An ActionResult containing a ResultResponse with an IEnumerable of GetEmployeesDTO after the deletion.</returns>
        [HttpDelete, Route("Delete_Employee_ID")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetEmployeesDTO>>>> DeleteEmployeeByIdAsync(Guid ID)
        {
            var result = await _employeesServices.DeleteEntityByIdAsync(ID);

            return Ok(result);
        }

        /// <summary>
        /// Get all Employee with Pagination feature
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>An ActionResult containing a IActionResult with an IEnumerable of GetEmployeesDTO.</returns>
        [HttpGet, Route("Return_Employee_using_Pagination")]
        public async Task<IActionResult> GetAllEmployeeUsingPaginationAsync([FromQuery] PaginationFiltering filter)
        {
            var route = Request.Path.Value;

            var result = await _employeesServices.GetAllEmployeeUsingPaginationAsync(filter, _uriService, route);   

            return Ok(result);
        }
    }
}
