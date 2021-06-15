using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Testing.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn ;
        
        public ProductRepository()
        {
            _conn = conn;
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}