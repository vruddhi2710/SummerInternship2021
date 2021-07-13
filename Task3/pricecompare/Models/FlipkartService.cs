using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecompare.Models
{
    class FlipkartService
    {
        Dictionary<string, ProductInfo> flipkartProducts = new Dictionary<string, ProductInfo>();
        public async Task<Dictionary<string, ProductInfo>> GetFlipkartProducts(List<string> skuList) //Task<Dictionary<string,ProductInfo>> should be the return type
        {
            List<ProductInfo> productList = new List<ProductInfo>()
            {
                new ProductInfo("300001", "Air Conditioner", 32, 40000) ,
                new ProductInfo("300002", "Air Cooler", 45, 30000),
                new ProductInfo("300003", "Fridge", 55, 20000),
             };

            await Task.Delay(1010);// delay for 1 Second to fetch data using await 
            foreach (var item in productList)
            {
                flipkartProducts.Add(item.SkuId, item);
            }
            return flipkartProducts;
        }

    }
}
