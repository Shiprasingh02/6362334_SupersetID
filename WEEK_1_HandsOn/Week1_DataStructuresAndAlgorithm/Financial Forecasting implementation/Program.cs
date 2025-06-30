using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Forecasting_implementation
{
    internal class Program
    {
         public static double PredictFutureValue(double presentValue, List<double> growthRates, int index)
            {
                if (index == growthRates.Count)
                {
                    return presentValue;
                }

                
                double updatedValue = presentValue * (1 + growthRates[index]);
                return PredictFutureValue(updatedValue, growthRates, index + 1);
            }

            static void Main()
            {
                double presentValue = 10000;  

                
                List<double> growthRates = new List<double> { 0.05, 0.06, 0.04 };

                
                double futureValue = PredictFutureValue(presentValue, growthRates, 0);

                Console.WriteLine($"Future value after {growthRates.Count} years: {futureValue:F2}");

                Console.ReadLine(); 
            }
        

    }
}








