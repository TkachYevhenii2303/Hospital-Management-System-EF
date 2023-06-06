using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Repositories;
using Hospital_Management_System_DAL.Repositories.Interfaces;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Unit_of_Work_Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext _context;

        public UnitOfWork(HospitalContext context)
        {
            _context = context;

            EmployeesRepository = new EmployeesRepository(_context);
        }

        public IEmployeesRepository EmployeesRepository { get; private set; }

        public async Task Complete() => await _context.SaveChangesAsync(); 

        public void Dispose() => _context.Dispose();
    }
}
