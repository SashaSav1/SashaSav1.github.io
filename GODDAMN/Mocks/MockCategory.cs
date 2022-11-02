using GODDAMN.Interfaces;
using GODDAMN.Models;
using System.Collections.Generic;

namespace GODDAMN.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Обувь", Description = "Побывайте в Италии из других стран.", Img = "/img/обувь2.jpg", CategoryId = 1},
                    new Category {CategoryName = "Штаны", Description = "Италия покроект ваши ноги красотой.", Img = "/img/штаны2.jpg", CategoryId = 2},
                    new Category {CategoryName = "Кофты", Description = "Италия не толкьо в душе, но и на тебе.", Img = "/img/кофты2.jpg", CategoryId = 3},
                    new Category {CategoryName = "Головные уборы", Description = "Нужно думать только об Италии.", Img = "/img/головные уборы2.jpg", CategoryId = 4}

                };
            }
        }
    }
}
