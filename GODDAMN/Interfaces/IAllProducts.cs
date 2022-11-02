using GODDAMN.Models;
using System.Collections;
using System.Collections.Generic;

namespace GODDAMN.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Product { get; }
        IEnumerable<Product> GetFavProducts { get;}
        Product GetObjectProduct(int ProductId);
    }
}
