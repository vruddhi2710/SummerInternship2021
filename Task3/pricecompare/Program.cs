using pricecompare.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace pricecompare
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo productInfo = new ProductInfo();
            List<string>productsList=productInfo.FetchProductDetails();
            foreach (var item in productsList)
            {
                Console.WriteLine(item);
            }
        }
    }

   
    
    
  

}
