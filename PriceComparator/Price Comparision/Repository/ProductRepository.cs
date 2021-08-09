using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            return DataSource();
        }

        private List<Product> DataSource()
        {
            return new List<Product>() { 
                new Product() { Name="Product1", SkuId="001", Stock=10, OwnPrice=500}, 
                new Product() { Name="Product2", SkuId="002", Stock=20, OwnPrice=1000},
                new Product() { Name="Product3", SkuId="003", Stock=30, OwnPrice=1500},
                new Product() { Name="Product4", SkuId="004", Stock=40, OwnPrice=2000},
                new Product() { Name="Product5", SkuId="005", Stock=50, OwnPrice=2500},
                new Product() { Name="Product6", SkuId="006", Stock=60, OwnPrice=3000},
                new Product() { Name="Product7", SkuId="007", Stock=70, OwnPrice=3500},
                new Product() { Name="Product8", SkuId="008", Stock=80, OwnPrice=4000},
                new Product() { Name="Product9", SkuId="009", Stock=90, OwnPrice=4500},

            };
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public string SkuId { get; set; }
        public int Stock { get; set; }
        public int OwnPrice { get; set; }
    }
}
