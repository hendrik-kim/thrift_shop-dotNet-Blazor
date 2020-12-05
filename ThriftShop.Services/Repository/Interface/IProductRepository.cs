using System.Collections.Generic;
using ThriftShop.Data.Models;

namespace ThriftShop.UseCaces.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string fileter);
        Product GetProduct(int id);
    }
}
