using System.Collections.Generic;
using Northwind.Shared.DomainModels;

namespace Northwind.Shared.Interfaces.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }
}