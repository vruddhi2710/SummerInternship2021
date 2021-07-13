using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecompare.Models
{
    class ProductInfo
    {
        public static Dictionary<string, ProductInfo> skuCache = new Dictionary<string, ProductInfo>(); //Dictionary<SkuID,ProductInfo>
        public bool inProgress;
        public string SkuId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public ProductInfo()
        {
            SkuId = string.Empty;
            ProductName = string.Empty;
            Stock = -1;
            Price = -1;
            inProgress = false;
        }
        public ProductInfo(string id, string name, int stock, int price)
        {
            SkuId = id;
            ProductName = name;
            Stock = stock;
            Price = price;
            inProgress = false;

        }
        public List<string> FetchProductDetails()
        {
            List<string> Products = new List<string>();
            if (inProgress)
            {
                return Products;
            }
            if (skuCache.Count == 0)
            {
                PrepareResult();
            }

            return Products;
        }

        private async void PrepareResult()
        {
            inProgress = true;
            SAPService sp = new SAPService();
            Console.WriteLine("Delay Due to detching SUIDs from SAP");
            var skuList = await sp.GetSkuIdsFromSap();
            foreach (var s in skuList)
            {
                Console.Write(s + "\n");
            }

            AmazonService amazonService = new AmazonService();
            FlipkartService flipkartService = new FlipkartService();
            var amazonProducts = amazonService.GetAmazonProducts(skuList);
            var flipkartProducts = flipkartService.GetFlipkartProducts(skuList);
            amazonProducts.Wait(-1);
            flipkartProducts.Wait(-1);

            FillResultWithAmazonSkus();
            FillResultWithFlipKartSkus();

        }
        private void FillResultWithFlipKartSkus()
        {
            
        }

        private void FillResultWithAmazonSkus()
        {
            
        }
    }
}
