using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Unit_of_Work_Pattern
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext _context;

        public UnitOfWork(HospitalContext context)
        {
            _context = context;
        }

        public async void Complete() => await _context.SaveChangesAsync(); 

        public void Dispose() => _context.Dispose();
    }
}
