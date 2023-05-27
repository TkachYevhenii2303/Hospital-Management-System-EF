using Hospital_Management_System_BLL.Services.Interfaces;
using Hospital_Management_System_DAL.Fluent_Validation.Configurations;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;

namespace Hospital_Management_System_API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesServices _employeesServices;

        public EmployeesController(IEmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;
        }

        [HttpGet, Route("Return_all_Employee")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetEmployeesDTO>>>> GetAllEmployeesAsync()
        {
            var result = await _employeesServices.GetAllEmployeesAsync();
            
            return Ok(result);
        }

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

        [HttpPost, Route("Insert_Employee")]
        public async Task<ActionResult<ResultResponse<GetEmployeesDTO>>> InsertEmployeeAsync(InsertEmployeeDTO employeeDTO)
        {
            var result = await _employeesServices.InsertEmployeeAsync(employeeDTO);

            return Ok(result);
        }

        [HttpPut, Route("Update_Employee")]
        public async Task<ActionResult<ResultResponse<GetEmployeesDTO>>> UpdateEmployeeAsync(UpdateEmployeeDTO employeeDTO)
        {
            var result = await _employeesServices.UpdateEmployeeAsync(employeeDTO);

            return Ok(result);
        }

        [HttpDelete, Route("Delete_Employee_ID")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetEmployeesDTO>>>> DeleteEmployeeByIdAsync(Guid ID)
        {
            var result = await _employeesServices.DeleteEntityByIdAsync(ID);

            return Ok(result);
        }
    }
}
