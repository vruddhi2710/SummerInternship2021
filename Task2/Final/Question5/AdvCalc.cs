using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class AdvCalc
    {
        List<double> largeList = new List<double>();
        public static void Main()
        {
            ProcessAsync();
            Console.ReadKey();
        }
        public async static void ProcessAsync()
        {
            AdvCalc advCalc = new AdvCalc();
            await Task.Run(() => advCalc.PrepareLargeList());
            advCalc.SortInPlace();
            List<double> sqrts = advCalc.SquareRoot();
            double sum = advCalc.SumAll();

            Console.WriteLine("Doing calculations...");

            advCalc.DisplayResults(sqrts, sum);
        }
        private void DisplayResults(List<double> sqrts, double sum)
        {
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < largeList.Count; i++)
                Console.WriteLine($"Square root of {largeList[i]} is {sqrts[i]}");
        }
        private double SumAll()
        {
            return largeList.Sum();
        }
        private List<double> SquareRoot()
        {
            List<double> sq = new List<double>();
            largeList.ForEach(f => sq.Add(Math.Sqrt(f)));
            return sq;
        }
        private void SortInPlace()
        {
            largeList.Sort();
        }
        private void PrepareLargeList()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
                largeList.Add(r.NextDouble() * 1000.0);
        }
    }
}
