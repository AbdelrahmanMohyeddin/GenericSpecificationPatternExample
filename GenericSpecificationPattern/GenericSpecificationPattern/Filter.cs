namespace SpecificationPattern
{
    public class Filter : BaseSpecification<Product>
    {
        public Filter()
        {
        }

        public Filter(string search)
            : base(x => x.Name.ToLower().Contains(search.ToLower()))
        {
        }
    }
}
