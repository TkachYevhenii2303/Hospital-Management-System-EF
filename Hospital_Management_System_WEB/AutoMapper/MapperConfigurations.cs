using AutoMapper;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Pagination;
using Hospital_Management_System_DAL.RegistrationModels;
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

            PagedResponseConfigurationsMapping();

            UserRegistrationConfigurationMapping();
        }

        private void EmployeesConfigurationsMapping()
        {
            CreateMap<Employees, GetEmployeesDTO>()
                .ForMember(destination => destination.FullName, options => options.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<InsertEmployeeDTO, Employees>();

            CreateMap<UpdateEmployeeDTO, Employees>();

            CreateMap<UpdateEmployeeDTO, GetEmployeesDTO>().ReverseMap();
        }

        private void ResultResponseConfigurationsMapping()
        {
            CreateMap(typeof(ResultResponse<>), typeof(ResultResponse<>));
        }

        private void PagedResponseConfigurationsMapping()
        {
            CreateMap(typeof(PagedResponse<>), typeof(PagedResponse<>));
        }

        private void UserRegistrationConfigurationMapping()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
