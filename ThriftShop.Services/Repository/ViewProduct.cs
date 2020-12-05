using ThriftShop.Data.Models;
using ThriftShop.Services.Repository.IRepository;
using ThriftShop.UseCaces.PluginInterfaces.DataStore;

namespace ThriftShop.Services.Repository.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository _productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}
