﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Specification_Pattern.Interfaces
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> Criteria { get; }

        List<Expression<Func<TEntity, object>>> Includes { get; }    

        Expression<Func<TEntity, object>> OrderBy { get; } 

        Expression<Func<TEntity, object>> OrderByDescending { get; } 
    }
}
