using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria { get; }
        Expression<Func<T,object>> OrderByAsc { get; }
        Expression<Func<T, object>> OrderByDesc { get; }
    }
}
