namespace _4.Fix_Emails___Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            var namesAndEmails = new Dictionary<string, string>();
            string name = null;

            while (name != "stop")
            {
                name = Console.ReadLine();
                if (name != "stop")
                {
                    namesAndEmails[name] = Console.ReadLine();
                    var mailToArray = namesAndEmails[name].ToCharArray();
                    var lenght = mailToArray.Length - 2;
                    var endOfMail = mailToArray.Skip(lenght).ToArray();

                    if (string.Join("", endOfMail).ToLower() == "us" || string.Join("", endOfMail).ToLower() == "uk")
                    {
                        namesAndEmails.Remove(name);
                    }
                }
                else
                {
                    foreach (var item in namesAndEmails)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
