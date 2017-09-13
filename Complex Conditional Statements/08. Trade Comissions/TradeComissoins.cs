namespace _08.Trade_Comissions
{
    using System;

    public class TradeComissoins
    {
       public static void Main()
        {
            var town = Console.ReadLine();
            var sells = decimal.Parse(Console.ReadLine());
            var commission = 0.0m;

            if (town.ToLower() == "sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = 0.05m;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = 0.07m;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = 0.08m;
                }
                else if (sells > 10000)
                {
                    commission = 0.12m;
                }
            }
            else if (town.ToLower() == "varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = 0.045m;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = 0.075m;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = 0.10m;
                }
                else if (sells > 10000)
                {
                    commission = 0.13m;
                }
            }
            else if (town.ToLower() == "plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = 0.055m;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = 0.08m;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = 0.12m;
                }
                else if (sells > 10000)
                {
                    commission = 0.145m;
                }
            }
            var totalCommission = commission * sells;
            if (!(town.ToLower() == "sofia" || town.ToLower() == "plovdiv" || town.ToLower() == "varna") || (sells < 0))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", totalCommission);
            }
        }
    }
}
