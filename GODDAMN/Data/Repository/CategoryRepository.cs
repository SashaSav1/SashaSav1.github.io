using GODDAMN.Interfaces;
using GODDAMN.Models;
using System.Collections.Generic;

namespace GODDAMN.Data.Repository
{
    public class CategoryRepository : IProductsCategory
    {
        private readonly ApplicationDbContext _content;
        public CategoryRepository(ApplicationDbContext content)
        {
            _content = content;
        }
        public IEnumerable<Category> AllCategories => _content.Categories;
    }
}
