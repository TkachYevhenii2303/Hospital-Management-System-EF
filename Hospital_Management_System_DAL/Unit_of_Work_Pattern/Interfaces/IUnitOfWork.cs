using Hospital_Management_System_DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeesRepository EmployeesRepository { get; }

        void Complete();
    }
}
