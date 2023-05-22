using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Specification_Pattern.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces
{
    public interface IGenericRepository<TEntity> 
        where TEntity : BaseEntity
    {
        Task<ResultResponse<IEnumerable<TEntity>>> GetAllInformationsAsync();

        Task<ResultResponse<TEntity>> GetEntityByIdAsync(Guid ID);

        Task<ResultResponse<TEntity>> InsertEntityAsync(TEntity entity);

        Task<ResultResponse<TEntity>> UpdateEntityAsync(TEntity entity, Guid ID);

        Task<ResultResponse<IEnumerable<TEntity>>> DeleteEntityByIdAsync(Guid ID);

        IEnumerable<TEntity> FindWithSpecificationPattern(ISpecification<TEntity>? specification = null);
    }
}
