using System.Collections.Generic;
using Northwind.Shared.DomainModels;

namespace Northwind.Shared.Interfaces.Data
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}