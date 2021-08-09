using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Price_Comparison.Models;
using Price_Comparison.Repository;

namespace Price_Comparison.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Dictionary<string, ProductModel> skuCache = new Dictionary<string, ProductModel>();
        private SAPService _sapService;
        private AmazonService _amazonService;
        private FlipkartService _flipkartService;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _amazonService = new AmazonService();
            _sapService = new SAPService();
            _flipkartService = new FlipkartService();
        }

        public IActionResult Index()
        {
            var temp = GetAllProducts();

            foreach (var item in temp)
             {
                if (!skuCache.ContainsKey(item.SkuId))
                {
                    skuCache.Add(item.SkuId, item);
                }
             }
            ViewData["skuCache"] = skuCache;
            return View();
        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<ProductModel> GetAllProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> result = productRepository.GetAllProducts();

            List<ProductModel> allItems = new List<ProductModel>();
            ConvertProductToModel(result, allItems);
            var skuList = _sapService.GetSkuList();

            var flipkartSku = _flipkartService.GetAllProducts(skuList);         //Api call to Flipkart to get matching Skus
            var amazonSku = _amazonService.GetAllProducts(skuList);             //Api call to Amazon to get matching Skus

            flipkartSku.Wait(-1);
            amazonSku.Wait(-1);

            FillResultwithFlipkartSkus(allItems,  flipkartSku.Result);
            FillResultwithAmazonSkus(allItems,  amazonSku.Result);

            return allItems;
        }

        private void ConvertProductToModel(List<Product> result, List<ProductModel> allItems)
        {
            foreach (var item in result)
            {
                allItems.Add(new ProductModel() { SkuId = item.SkuId, Name=item.Name, Stock = item.Stock, OwnPrice=item.OwnPrice});
            }
        }

        private void FillResultwithAmazonSkus(List<ProductModel> allItems, Dictionary<string, ProductModel> amazonItems )
        {
          
            foreach (var item in amazonItems)
            {
                var temp = allItems.Where(x => x.SkuId == item.Key).FirstOrDefault();

                if (temp != null)
                {
                    temp.AmazonCompetitors = item.Value.AmazonCompetitors;

                }
              
            }

            //foreach (var item in allItems)
            //{
            //    var temp = result.Where(x => x.SkuId == item.SkuId).FirstOrDefault();
            //    // item.SkuId = temp.SkuId;
            //    if (temp != null && (item.Name == string.Empty || item.OwnPrice != -1 || item.Stock != -1))
            //    {
            //        item.Name = temp.Name;
            //        item.OwnPrice = temp.OwnPrice;
            //        item.Stock = temp.Stock;
            //    }
            //}
        }

        private void FillResultwithFlipkartSkus(List<ProductModel> allItems, Dictionary<string, ProductModel> flipkartItems)
        {

            foreach (var item in flipkartItems)
            {
                var temp = allItems.Where(x => x.SkuId == item.Key).FirstOrDefault();

                if (temp != null)
                {
                    temp.FlipkartCompetitors = item.Value.FlipkartCompetitors;
                }
               
            }

            //foreach (var item in allItems)
            //{
            //    var temp = result.Where(x => x.SkuId == item.SkuId).FirstOrDefault();
            //    // item.SkuId = temp.SkuId;
            //    if (temp != null && (item.Name == string.Empty || item.OwnPrice != -1 || item.Stock != -1))
            //    {
            //        item.Name = temp.Name;
            //        item.OwnPrice = temp.OwnPrice;
            //        item.Stock = temp.Stock;
            //    }
            //}
        }
    }
}
