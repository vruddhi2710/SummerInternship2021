using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class FlipkartService
    {

        private Flipkartrepository _flipkartRepository;
        private List<Flipkart> flipkartDb;
        public FlipkartService()
        {
            _flipkartRepository = new Flipkartrepository();
        }
        public async Task<Dictionary<string, ProductModel>> GetAllProducts(List<string> skuList)
        {
            ProductModel productModel = new ProductModel();
            Dictionary<string, ProductModel> flipkartSkus = new Dictionary<string, ProductModel>();
            List<Task<Flipkart>> allFlipkartItems = new List<Task<Flipkart>>();

            //var allProducts = _productRepository.GetAllProducts();


            flipkartDb = _flipkartRepository.GetSkus();       //get all items from flipkart repository
            var flipkartSkuList = await CheckSkuId(skuList);     //get valid SkuIds

            foreach (var item in flipkartSkuList)
            {
                allFlipkartItems.Add(Task.Run(() => GetValidItemInfo(item)));
            }
            var Flipkartitem = await Task.WhenAll(allFlipkartItems);


            foreach (var item in Flipkartitem)
            {
                flipkartSkus.Add(item.SkuId, new ProductModel() { SkuId = item.SkuId, FlipkartCompetitors = item.companyPrice});
            }
             return flipkartSkus;
        }

        private Flipkart GetValidItemInfo(string skuId)
        {
            var temp = flipkartDb.Where(item => item.SkuId == skuId).FirstOrDefault();
            return temp;
        }

        private async Task<List<string>> CheckSkuId(List<string> skuList)
        {
            List<string> itemSkuList = new List<string>();
            foreach (var item in skuList)
            {
                if (await Task.Run(() => SearchFlipkartRepository(item)))
                {
                    itemSkuList.Add(item);
                }
            }

            return itemSkuList;
        }

        private bool SearchFlipkartRepository(string skuId)
        {
            foreach (var item in flipkartDb)
            {
                if (skuId == item.SkuId) { return true; }
            }
            return false ;
        }

        

    }
    class Flipkartrepository
    {
        public List<Flipkart> GetSkus()
        {
            return DataSource();
        }
        private List<Flipkart> DataSource()
        {
            return new List<Flipkart>() { 
                new Flipkart() { SkuId="005", companyPrice = new Dictionary<string, int>() { {"FCompany1", 1000 }, { "FCompany2", 1500 } } },
                new Flipkart() { SkuId="006", companyPrice = new Dictionary<string, int>() { {"FCompany4", 2000 }, { "FCompany2", 500 } } },
                new Flipkart() { SkuId="003", companyPrice = new Dictionary<string, int>() { {"FCompany2", 1000 }, { "FCompany1", 1500 } } },
                new Flipkart() { SkuId="001", companyPrice = new Dictionary<string, int>() { {"FCompany3", 2000 }, { "FCompany5", 500 } } }, 
                new Flipkart() { SkuId="009", companyPrice = new Dictionary<string, int>() { {"FCompany1", 1000 }, { "FCompany2", 1500 } } },
                new Flipkart() { SkuId="008", companyPrice = new Dictionary<string, int>() { {"FCompany5", 2000 }, { "FCompany6", 500 } } },
            };
        }
    }
    class Flipkart
    {
        public string SkuId { get; set; }
        public Dictionary<string, int> companyPrice { get; set; }

        public Flipkart()
        {
            SkuId = null;
            companyPrice = null;
        }
    }
}
