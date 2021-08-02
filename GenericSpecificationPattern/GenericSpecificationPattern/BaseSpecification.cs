using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T,bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }


        public Expression<Func<T, object>> OrderByAsc { get; private set; }

        public Expression<Func<T, object>> OrderByDesc { get; private set; }


        protected void AddOrderByAsc(Expression<Func<T,object>> OrderByAscExpression)
        {
            OrderByAsc = OrderByAscExpression;
        }

        protected void AddOrderByDesc(Expression<Func<T, object>> OrderByDescExpression)
        {
            OrderByDesc = OrderByDescExpression;
        }

    }
}
