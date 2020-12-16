using System.Collections.Generic;

namespace KCMS.Model
{
    public class Category : Entity
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
