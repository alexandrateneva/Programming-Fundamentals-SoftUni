namespace _03.Valid_Usernames___Exercises
{
    using _03.Valid_Usernames___Exercisese;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsername
    {
        public static void Main()
        {
            var usernames = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\b[A-Za-z]\w{2,24}\b");

            var listOfValidUsers = new List<Username>();

            foreach (var username in usernames)
            {
                if (regex.IsMatch(username))
                {
                    var currentValidUser = new Username();
                    {
                        currentValidUser.Name = username;
                        currentValidUser.Length = username.Length;
                    }
                    listOfValidUsers.Add(currentValidUser);
                }
            }
            var maxSum = 0;
            var currentSum = 0;
            string firstName = null;
            string secondName = null;
            string finalName1 = null;
            string finalName2 = null;
            for (int i = 0; i < listOfValidUsers.Count - 1; i++)
            {
                currentSum = listOfValidUsers[i].Length + listOfValidUsers[i + 1].Length;
                firstName = listOfValidUsers[i].Name;
                secondName = listOfValidUsers[i + 1].Name;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    finalName1 = firstName;
                    finalName2 = secondName;
                }
            }
            Console.WriteLine(finalName1);
            Console.WriteLine(finalName2);
        }
    }
}
