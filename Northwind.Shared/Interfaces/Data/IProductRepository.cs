using System.Collections.Generic;
using System.Threading.Tasks;
using Northwind.Shared.DomainModels;

namespace Northwind.Shared.Interfaces.Data
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}