using System.Collections.Generic;
using System.Linq;
using ThriftShop.Data.Models;
using ThriftShop.UseCaces.PluginInterfaces.DataStore;

namespace ThriftShop.Services.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {

            products = new List<Product>
            {
                new Product{ Id = 1, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 1, Brand = "Brand", Name = "N2ame", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 2, Brand = "Brand", Name = "Name3", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 3, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 4, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 5, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 6, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 7, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" },
                new Product { Id = 8, Brand = "Brand", Name = "Name", Price = 555, ImageLink = "http://www.ggg.com" }
            };
        }

        IEnumerable<Product> IProductRepository.GetProducts(string fileter)
        {
            if (string.IsNullOrWhiteSpace(fileter)) return products;

            return products.Where(x => x.Name.ToLower().Contains(fileter.ToLower()));
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }
    }

}

