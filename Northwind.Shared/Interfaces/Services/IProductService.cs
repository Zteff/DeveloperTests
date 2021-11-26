using System.Collections.Generic;
using System.Threading.Tasks;
using Northwind.Shared.DomainModels;

namespace Northwind.Shared.Interfaces.Services
{
    public interface IProductService
    {
        Product GetProduct(int id);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}