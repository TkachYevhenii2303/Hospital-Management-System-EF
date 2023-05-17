using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Generic_Repository_Pattern;
using Hospital_Management_System_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Repositories
{
    internal class EmployeesRepository : GenericRepository<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(HospitalContext context) : base(context)
        {
        }
    }
}
