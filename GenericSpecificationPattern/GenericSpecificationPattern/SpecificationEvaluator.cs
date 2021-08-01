using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SpecificationPattern
{
    public class SpecificationEvaluator<TEntity> where TEntity : class
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery,
            ISpecification<TEntity> Spec)
        {
            var query = inputQuery;

            if (Spec.Criteria != null)
            {
                query = query.Where(Spec.Criteria);
            }
            return query;
        }
    }
}
