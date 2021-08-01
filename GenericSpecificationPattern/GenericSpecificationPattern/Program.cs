using SpecificationPattern;
using System;
using System.Linq;

namespace GenericSpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchInput;
            while (true)
            {
                searchInput = Console.ReadLine();
                if (searchInput == "end()")
                    break;
                var Spec = new Filter(searchInput);
                var Products = SpecificationEvaluator<Product>.GetQuery(_context.Products().AsQueryable(), Spec).ToList();

                foreach (var item in Products)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
