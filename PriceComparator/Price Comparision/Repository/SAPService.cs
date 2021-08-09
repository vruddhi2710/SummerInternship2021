using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Price_Comparison.Repository
{
    public class SAPService
    {

        public List<string> GetSkuList()
        {
            return FetchSkuId();
        }

        private List<string> FetchSkuId()
        {
            return new List<string>() { "001", "002", "003", "004", "005", "006", "007", "008", "009" };
        }
    }
}
