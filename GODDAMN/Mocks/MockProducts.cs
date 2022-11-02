using GODDAMN.Controllers;
using GODDAMN.Data;
using GODDAMN.Interfaces;
using GODDAMN.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace GODDAMN.Mocks
{
    public class MockProducts : IAllProducts
    {


        private readonly IProductsCategory _CategoryProducts = new MockCategory();
        public IEnumerable<Product> Product
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        Name = "Худи Palm Angels",
                        Description = "Кофта с капюшоном",
                        Img = "/img/1.jpg",
                        Price = 149,
                        IsFavourite = true,
                        Available = true,
                        Category = _CategoryProducts.AllCategories.ElementAt(2)
                    },
                    new Product
                    {
                        Name = "Кроссовки Sergio Tacchini",
                        Description = "Мягкие кроссовки",
                        Img = "",
                        Price = 269,
                        IsFavourite = true,
                        Available = true,
                        Category = _CategoryProducts.AllCategories.ElementAt(0)
                    },
                    new Product
                    {
                        Name = "Штаны FILA",
                        Description = "Спортивные современные штаны",
                        Img = "",
                        Price = 99,
                        IsFavourite = true,
                        Available = true,
                        Category = _CategoryProducts.AllCategories.ElementAt(1)
                    }
                };
            }
            
        }
        public IEnumerable<Product> GetFavProducts { get ; set; }

        public Product GetObjectProduct(int ProductId)
        {
            throw new System.NotImplementedException();
        }
    }
}
