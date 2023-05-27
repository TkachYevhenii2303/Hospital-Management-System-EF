using AutoMapper;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Wrapper_Response;
using Hospital_Management_System_DTO.Data_transfer_objects.Result_Request_DTO;

namespace Hospital_Management_System_API.AutoMapper
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            EmployeesConfigurationsMapping();

            ResultResponseConfigurationsMapping();
        }

        private void EmployeesConfigurationsMapping()
        {
            CreateMap<Employees, GetEmployeesDTO>()
                .ForMember(destination => destination.FullName, options => options.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<InsertEmployeeDTO, Employees>();

            CreateMap<UpdateEmployeeDTO, Employees>();  
        }

        private void ResultResponseConfigurationsMapping()
        {
            CreateMap(typeof(ResultResponse<>), typeof(ResultResponse<>));
        }
    }
}
