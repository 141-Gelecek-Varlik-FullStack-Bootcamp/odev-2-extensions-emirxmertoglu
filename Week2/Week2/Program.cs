using System;
using ExtensionMethods;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollar = 100;
            var tl = 100;
            Console.WriteLine(dollar.DollarToTL(13.30));
            Console.WriteLine(tl.TLToDollar(0.076));
        }
    }
}
