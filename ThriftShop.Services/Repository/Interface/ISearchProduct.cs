using System;
using System.Collections.Generic;
using System.Text;
using ThriftShop.Data.Models;

namespace ThriftShop.Services.Repository.IRepository
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}