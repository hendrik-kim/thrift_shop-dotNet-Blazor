using System.Collections.Generic;
using ThriftShop.Data.Models;
using ThriftShop.Services.Repository.IRepository;
using ThriftShop.UseCaces.PluginInterfaces.DataStore;

namespace ThriftShop.Services.Repository.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository _productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string filter)
        {
            return _productRepository.GetProducts(filter);
        }
    }
}
