using Lab2.Model;

namespace Lab2_Sharp.Extensions
{
    internal static class FactoryExtensions
    {
        private const decimal InvestmentRatio = 0.4M;
        public static decimal ValueIncomeFromInvestition(this Factory factory, decimal investiotion)
        {
            return (investiotion / factory.FactoryHR.IncomePerSlave) * InvestmentRatio + investiotion;
        }
    }
}
