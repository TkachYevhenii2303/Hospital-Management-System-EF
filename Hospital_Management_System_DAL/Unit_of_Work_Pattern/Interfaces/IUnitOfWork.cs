using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Unit_of_Work_Pattern.Interfaces
{
    internal interface IUnitOfWork : IDisposable
    {
        public void Complete();
    }
}
