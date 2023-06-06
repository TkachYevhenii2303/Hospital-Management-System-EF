using Hospital_Management_System_DAL.Specification_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Specification_Pattern
{
    internal class Specification<TEntity> : ISpecification<TEntity>
    {
        public Specification() { }

        public Specification(Expression<Func<TEntity, bool>> criteria) => Criteria = criteria;

        public Expression<Func<TEntity, bool>> Criteria { get; }

        public List<Expression<Func<TEntity, object>>> Includes { get; } = new List<Expression<Func<TEntity, object>>>(); 

        public Expression<Func<TEntity, object>> OrderBy { get; private set; }

        public Expression<Func<TEntity, object>> OrderByDescending { get; private set; }

        protected void AddInclude(Expression<Func<TEntity, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<TEntity, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        
        protected void AddOrderByDescending(Expression<Func<TEntity, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }
    }
}
