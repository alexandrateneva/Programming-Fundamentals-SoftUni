namespace _04.Winning_Ticket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static Regex regSymbols = new Regex(@"\@{6,}|\#{6,}|\${6,}|\^{6,}");

        static void Main()
        {
            var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            foreach (var ticket in tickets)
                Console.WriteLine(checkTicket(ticket));
        }

        public static string checkTicket(string ticket)
        {
            if (ticket.Length != 20)
                return "invalid ticket";

            var left = regSymbols.Match(ticket.Substring(0, 10));
            var right = regSymbols.Match(ticket.Substring(10));

            if (left.Success && right.Success)
            {
                var minSymbols = Math.Min(left.Value.Length, right.Value.Length);
                return "ticket \"" + ticket + "\" - " + minSymbols + left.Value[0] + ((minSymbols == 10) ? " Jackpot!" : "");
            }

            return "ticket \"" + ticket + "\" - no match";
        }
    }
}
