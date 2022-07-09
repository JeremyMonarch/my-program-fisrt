using Lesson28.EF.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson28.EF
{
    public static class Program
    {
        public static async Task Main()
        {
            var context = new ShopDataContext();

            var categories = await context.Categories.Include(x => x.Products).ToListAsync();

            foreach (var category in categories)
            {
                Console.WriteLine($"Products: {category.Title}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"\t {product.Title}, price {product.Price}");
                }
            }
        }
    }
}
