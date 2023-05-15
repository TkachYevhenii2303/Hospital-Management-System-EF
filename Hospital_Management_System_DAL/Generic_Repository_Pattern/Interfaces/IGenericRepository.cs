using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Wrapper_Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces
{
    internal interface IGenericRepository<TEntity> 
        where TEntity : BaseEntity
    {
        public Task<ResultResponse<IEnumerable<TEntity>>> GetAllInformationsAsync();

        public Task<ResultResponse<TEntity>> GetEntityByIdAsync(Guid ID);

        public Task<ResultResponse<TEntity>> InsertEntityAsync(TEntity entity);

        public Task<ResultResponse<TEntity>> UpdateEntityAsync(TEntity entity, Guid ID);

        public Task<ResultResponse<IEnumerable<TEntity>>> DeleteEntityByIdAsync(Guid ID);
    }
}
