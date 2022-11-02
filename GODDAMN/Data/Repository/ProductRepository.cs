using GODDAMN.Interfaces;
using GODDAMN.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GODDAMN.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly ApplicationDbContext _content;
        public ProductRepository(ApplicationDbContext content)
        {
            _content = content;
        }

        public IEnumerable<Product> Product => _content.Products.Include(c => c.Category);

        public IEnumerable<Product> GetFavProducts => _content.Products.Where(p => p.IsFavourite).Include(c => c.Category);

        public Product GetObjectProduct(int ProductId) => _content.Products.FirstOrDefault(p => p.Id == ProductId);
    }
        
}
