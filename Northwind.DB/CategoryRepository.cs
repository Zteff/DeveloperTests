using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using Northwind.Shared.DomainModels;
using Northwind.Shared.Interfaces.Data;

namespace Northwind.DB
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string _connectionString;

        public CategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            string sql = @"SELECT [CategoryID]
                            ,[CategoryName]
                            ,[Description]
                            FROM [Northwind].[dbo].[Categories]";
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Category>(sql);
            }
        }
    }
}
