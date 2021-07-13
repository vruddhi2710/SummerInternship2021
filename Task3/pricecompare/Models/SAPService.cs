using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecompare.Models
{
    class SAPService
    {
        List<string> SkuIdsOfProducs;
        public async Task<List<string>> GetSkuIdsFromSap()
        {
            SkuIdsOfProducs = new List<string>()
            {
                "300001","300002","300003","300004","300005"
            };
            await Task.Delay(TimeSpan.FromSeconds(1));
            return SkuIdsOfProducs;
        }
    }
}
