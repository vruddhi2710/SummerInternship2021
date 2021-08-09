using Price_Comparison.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class AmazonService
    {
        private AmazonRepository _amazonRepository;
        private List<Amazon> amazonDb;
        public AmazonService()
        {
            _amazonRepository = new AmazonRepository();
        }

        public async Task<Dictionary<string, ProductModel>> GetAllProducts(List<string> skuList)
        {
            ProductModel productModel = new ProductModel();
            Dictionary<string, ProductModel> amazonSkus = new Dictionary<string, ProductModel>();
            List<Task<Amazon>> allAmazonItems = new List<Task<Amazon>>();

            amazonDb = _amazonRepository.GetSkus();       //get all items from amazon repository
            var amazonSkuList = await CheckSkuId(skuList);     //get valid SkuIds

            foreach (var item in amazonSkuList)
            {
                allAmazonItems.Add(Task.Run(() => GetValidItemInfo(item)));
            }
            var amazonItem = await Task.WhenAll(allAmazonItems);


            foreach (var item in amazonItem)
            {
                amazonSkus.Add(item.SkuId, new ProductModel() { SkuId = item.SkuId, AmazonCompetitors = item.companyPrice });

            }
            return amazonSkus;
        }

        private Amazon GetValidItemInfo(string skuId)
        {
            var temp = amazonDb.Where(item => item.SkuId == skuId).FirstOrDefault();
            return temp;
        }

        private async Task<List<string>> CheckSkuId(List<string> skuList)
        {
            List<string> itemSkuList = new List<string>();
            foreach (var item in skuList)
            {
                if (await Task.Run(() => SearchAmazonRepository(item)))
                {
                    itemSkuList.Add(item);
                }
            }

            return itemSkuList;
        }

        private bool SearchAmazonRepository(string skuId)
        {
            foreach (var item in amazonDb)
            {
                if (skuId == item.SkuId) { return true; }
            }
            return false;
        }

    }


    class AmazonRepository
    {
        public List<Amazon> GetSkus()
        {
            return DataSource();
        }
        private List<Amazon> DataSource()
        {
            return new List<Amazon>() {
                new Amazon() { SkuId="005", companyPrice = new Dictionary<string, int>() { {"ACompany1", 1000 }, { "ACompany2", 1500 } } },
                new Amazon() { SkuId="006", companyPrice = new Dictionary<string, int>() { {"ACompany4", 2000 }, { "ACompany2", 500 } } },
                new Amazon() { SkuId="002", companyPrice = new Dictionary<string, int>() { {"ACompany2", 1000 }, { "ACompany1", 1500 }, { "ACompany9", 4660} } },
                new Amazon() { SkuId="001", companyPrice = new Dictionary<string, int>() { {"ACompany3", 2000 }, { "ACompany5", 500 } } },
                new Amazon() { SkuId="009", companyPrice = new Dictionary<string, int>() { {"ACompany1", 1000 }, { "ACompany2", 1500 } } },
                new Amazon() { SkuId="008", companyPrice = new Dictionary<string, int>() { {"ACompany5", 2000 }, { "ACompany6", 500 } } },
            };
        }
    }
   public class Amazon
    {
        public string SkuId { get; set; }
        public Dictionary<string, int> companyPrice { get; set; }

        public Amazon()
        {
            SkuId = null;
            companyPrice = null;
        }
    }
}
