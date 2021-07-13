using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecompare.Models
{
    class AmazonService
    {
        Dictionary<string, ProductInfo> amazonProducts = new Dictionary<string, ProductInfo>();
        public async Task<Dictionary<string, ProductInfo>> GetAmazonProducts(List<string> skuList) //Task<Dictionary<string,ProductInfo>> should be the return type
        {
            List<ProductInfo> productList = new List<ProductInfo>()
            {
                new ProductInfo("300001", "Air Conditioner", 32, 40000) ,
                new ProductInfo("300003", "Fridge", 55, 20000),
                new ProductInfo("300004", "Led Light", 65, 1000),
                new ProductInfo("300005", "Oven", 75, 5000)
             };

            await Task.Delay(1010);// delay for 1 Second to fetch data using await 
            foreach (var item in productList)
            {
                amazonProducts.Add(item.SkuId, item);
            }
            return amazonProducts;
        }

    }
}
