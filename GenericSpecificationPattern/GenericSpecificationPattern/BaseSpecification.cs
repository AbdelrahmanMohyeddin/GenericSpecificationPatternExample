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
    }
}
