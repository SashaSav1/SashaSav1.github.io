using System.Collections.Generic;

namespace GODDAMN.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public List<Product> Products { get; set; }
    }
}
