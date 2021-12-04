using System;

namespace ExtensionMethods
{
    public static class ExchangeCurrency
    {
        public static string DollarToTL(this object dollar, double exchangeRate)
        {
            double total = Convert.ToDouble(dollar) * exchangeRate;
            return $"{dollar} United States Dollar = {total} Turkish lira";
        }

        public static string TLToDollar(this object tl, double exchangeRate)
        {
            double total = Convert.ToDouble(tl) * exchangeRate;
            return $"{tl} Turkish lira = {total} United States Dollar";
        }
    }
}
