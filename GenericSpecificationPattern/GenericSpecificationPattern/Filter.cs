namespace SpecificationPattern
{
    public class Filter : BaseSpecification<Product>
    {
        public Filter()
        {
        }

        public Filter(string search,string sort)
            : base(x => x.Name.ToLower().Contains(search.ToLower()))
        {
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "PriceAsc":
                        AddOrderByAsc(x => x.Price);
                        break;
                    case "PriceDesc":
                        AddOrderByDesc(x => x.Price);
                        break;
                    case "NameAsc":
                        AddOrderByAsc(x => x.Name);
                        break;
                    case "NameDesc":
                        AddOrderByDesc(x => x.Name);
                        break;
                    default:
                        AddOrderByAsc(x => x.Name);
                        break;
                }
            }
        }
    }
}
