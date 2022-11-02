using GODDAMN.Models;
using System.Collections;
using System.Collections.Generic;

namespace GODDAMN.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
