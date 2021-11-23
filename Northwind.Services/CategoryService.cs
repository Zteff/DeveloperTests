using System.Collections.Generic;
using Northwind.Shared.DomainModels;
using Northwind.Shared.Interfaces.Data;
using Northwind.Shared.Interfaces.Services;

namespace Northwind.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repos;

        public CategoryService(ICategoryRepository repos)
        {
            _repos = repos;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _repos.GetAllCategories();
        }
    }
}
