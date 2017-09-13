namespace _7.Sales_Report___Lab
{
    using System;
    using System.Collections.Generic;

    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var currentSale = Console.ReadLine().Split(' ');
                var sale = new Sales
                {
                    town = currentSale[0],
                    product = currentSale[1],
                    price = double.Parse(currentSale[2]),
                    quantity = double.Parse(currentSale[3])
                };
                if (!dict.ContainsKey(sale.town))
                {
                    dict[sale.town] = sale.quantity * sale.price;
                }
                else
                {
                    dict[sale.town] += sale.quantity * sale.price;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
