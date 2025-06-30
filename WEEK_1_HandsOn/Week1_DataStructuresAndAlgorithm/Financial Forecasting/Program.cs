using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Forecasting
{
    class Program
    {
        public static double CalculateFutureValue(double presentValue, double growthRate, int years)
        {
            if (years == 0)
            {
                return presentValue;
            }
            else
            {
                return CalculateFutureValue(presentValue, growthRate, years - 1) * (1 + growthRate);
            }
        }

        static void Main(string[] args)
        {
            
            double presentValue = 10000;  
            double growthRate = 0.05;     
            int years = 3;                 

            double futureValue = CalculateFutureValue(presentValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");
            Console.ReadLine(); 
        }
    }
}
