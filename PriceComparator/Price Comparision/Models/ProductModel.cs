using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string SkuId { get; set; }
        public int Stock { get; set; }
        public int OwnPrice { get; set; }
        public Dictionary<string, int> AmazonCompetitors { get; set; }
        public Dictionary<string, int> FlipkartCompetitors { get; set; }

        public ProductModel()
        {
            Name = string.Empty;
            SkuId = string.Empty;
            Stock = -1;
            OwnPrice = -1;
            AmazonCompetitors = null;
            FlipkartCompetitors = null;
        }
    }
}
