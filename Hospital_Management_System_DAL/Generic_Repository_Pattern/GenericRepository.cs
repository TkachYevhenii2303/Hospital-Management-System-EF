﻿using Hospital_Management_System_DAL;
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

namespace Hospital_Management_System_DAL.Generic_Repository_Pattern
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity>
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

            resultResponse.Message = $"Proccess is Good! We return all information from {GetAllInformationsAsync().GetType().Name}";

            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> GetEntityByIdAsync(Guid ID)
        {
            var resultResponse = new ResultResponse<TEntity>();

            resultResponse.Result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);

            resultResponse.Message = $"Proccess is Good! We return information from {GetEntityByIdAsync(ID).GetType().Name}";
            
            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> InsertEntityAsync(TEntity entity)
        {
            var resultResponse = new ResultResponse<TEntity>();

            entity.CreatedDateTime = DateTime.Now;

            await _context.Set<TEntity>().AddAsync(entity);

            resultResponse.Message = $"Proccess is Good! We insert information int {InsertEntityAsync(entity).GetType().Name}";

            return resultResponse;
        }

        public async Task<ResultResponse<TEntity>> UpdateEntityAsync(TEntity entity, Guid ID)
        {
            var resultResponse = new ResultResponse<TEntity>();

            try
            {
                entity.CreatedDateTime = DateTime.Now;

                entity.UpdatedDateTime = DateTime.Now;

                var result = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);

                if (result is null)
                {
                    throw new NullReferenceException($"The informations with {ID} ID not found!!!");
                }

                _context.Set<TEntity>().Update(entity);
            }
            catch (Exception exception)
            {
                resultResponse.Success = false;
                
                resultResponse.Message = $"Operations {UpdateEntityAsync(entity, ID).GetType().Name} is not valid!";

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
            }
            catch (Exception exception)
            {
                resultResponse.Success = false;
                
                resultResponse.Message = $"Operations {DeleteEntityByIdAsync(ID).GetType().Name} is not valid!";

                throw new Exception($"Somethig went wrong in Delete operation! {exception.Message}");
            }

            return resultResponse;
        }
    }
}