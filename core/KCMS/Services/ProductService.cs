using KCMS.Configuration;
using KCMS.Interfaces;
using KCMS.Model;

namespace KCMS.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IKCMSDatabaseSettings settings) : base(settings, CollectionNames.Products) { }
    }
}
