using System;

namespace Testing.Models
{
    public class Product
    {
        public Product()
        {
        }
        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CatalogID { get; set; }
        public int OnSalesOrderId { get; set; }
        public int StockLevel { get; set; }
 
    }
}