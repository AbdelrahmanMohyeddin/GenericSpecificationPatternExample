using SpecificationPattern;
using System;
using System.Linq;

namespace GenericSpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchInput, sort;
            while (true)
            {
                searchInput = Console.ReadLine();
                sort = Console.ReadLine();

                if (searchInput == "end()")
                    break;
                var Spec = new Filter(searchInput,sort);
                var Products = SpecificationEvaluator<Product>.GetQuery(_context.Products().AsQueryable(), Spec).ToList();

                foreach (var item in Products)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                }
            }
        }
    }
}
