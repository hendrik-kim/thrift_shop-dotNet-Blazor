using System;
using System.Collections.Generic;
using System.Text;
using ThriftShop.Data.Models;

namespace ThriftShop.Services.Repository.IRepository
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}
