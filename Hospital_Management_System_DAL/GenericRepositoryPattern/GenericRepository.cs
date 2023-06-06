using Hospital_Management_System_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_System_DAL.Context;
using Hospital_Management_System_DAL.Entities;
using Hospital_Management_System_DAL.Generic_Repository_Pattern.Interfaces;
using Hospital_Management_System_DAL.Wrapper_Response;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_System_DAL.Specification_Pattern.Interfaces;
using Hospital_Management_System_DAL.Specification_Pattern;

namespace Hospital_Management_System_DAL.Generic_Repository_Pattern
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly HospitalContext _context;

        public GenericRepository(HospitalContext context)
        {
            _context = context;
        }

        public async Task<ResultResponse<IEnumerable<TEntity>>> GetAllInformationsAsync()
        {
            var resultResponse = new ResultResponse<IEnumerable<TEntity>>();
            
            resultResponse.Result = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            resultResponse.Message = $"Proccess is Good! We return all information from {typeof(GenericRepository<TEntity>).FullName}";

            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> GetEntityByIdAsync(Guid ID)
        {
            var resultResponse = new ResultResponse<TEntity>();

            resultResponse.Result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);

            resultResponse.Message = $"Proccess is Good! We return information from {typeof(GenericRepository<TEntity>).FullName}";
            
            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> InsertEntityAsync(TEntity entity)
        {
            var resultResponse = new ResultResponse<TEntity>();

            entity.CreatedDateTime = DateTime.Now;

            await _context.Set<TEntity>().AddAsync(entity);

            resultResponse.Result = entity;

            resultResponse.Message = $"Proccess is Good! We insert information int {typeof(GenericRepository<TEntity>).FullName}";

            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> UpdateEntityAsync(TEntity entity)
        {
            var resultResponse = new ResultResponse<TEntity>();

            try
            {
                entity.CreatedDateTime = DateTime.Now;

                entity.UpdatedDateTime = DateTime.Now;

                var result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == entity.ID);

                if (result is null)
                {
                    throw new NullReferenceException($"The informations with {entity.ID} ID not found!!!");
                }

                _context.Set<TEntity>().Update(entity);

                resultResponse.Result = entity;
            }
            catch (Exception exception)
            {
                resultResponse.Success = false;
                
                resultResponse.Message = $"Operations {typeof(GenericRepository<TEntity>).FullName} is not valid!";

                throw new Exception($"Somethig went wrong in Delete operation! {exception.Message}");
            }

            return resultResponse;
        }

        public async Task<ResultResponse<IEnumerable<TEntity>>> DeleteEntityByIdAsync(Guid ID)
        {
            var resultResponse = new ResultResponse<IEnumerable<TEntity>>();

            try
            {
                var result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);

                if (result is null)
                {
                    throw new NullReferenceException($"The informations with {ID} ID not found!!!");
                }

                _context.Set<TEntity>().Remove(result);

                resultResponse.Result = await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception exception)
            {
                resultResponse.Success = false;
                
                resultResponse.Message = $"Operations {typeof(GenericRepository<TEntity>).FullName} is not valid!";

                throw new Exception($"Somethig went wrong in Delete operation! {exception.Message}");
            }

            return resultResponse;
        }

        public IEnumerable<TEntity> FindWithSpecificationPattern(ISpecification<TEntity>? specification = null)
        {
            return SpecificationEvaluator<TEntity>.GetQuery(_context.Set<TEntity>().AsQueryable(), specification);
        }
    }
}
