using System;

namespace UnitTestingSample
{
    public class VATCalculator
    {
        public decimal CalculateTotalValue(decimal netValue, decimal vatPercentage)
        {
            return netValue * (1 + vatPercentage);
        }

        public decimal CalculateNetValue(decimal totalValue, decimal vatPercentage)
        {
            return totalValue / (1 + vatPercentage);
        }
    }
}
