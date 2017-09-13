namespace _02.Array_Manipulator
{
    using System;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine().Split();
            while (line[0] != "end")
            {
                switch (line[0])
                {
                    case "exchange":
                        if (int.Parse(line[1]) >= 0 && int.Parse(line[1]) < input.Count)
                        {
                            var firstPart = int.Parse(line[1]) + 1;
                            var secondPart = input.Count - firstPart;
                            var arr1 = input.Take(firstPart).ToList();
                            var arr2 = input.Skip(firstPart).Take(secondPart).ToList();
                            input = arr2.Concat(arr1).ToList();
                        }
                        else { Console.WriteLine("Invalid index"); }; break;

                    case "max":
                        var resultMax = 0;
                        var helpArrMax = input.OrderByDescending(n => n).Distinct().ToList();
                        if (line[1] == "odd")
                        {
                            var number = helpArrMax.FirstOrDefault(a => a % 2 != 0);
                            resultMax = input.LastIndexOf(input.FindLast(a => a == number));
                        }
                        else if (line[1] == "even")
                        {
                            var number = helpArrMax.FirstOrDefault(a => a % 2 == 0);
                            resultMax = input.LastIndexOf(input.FindLast(a => a == number));
                        };
                        if (resultMax < 0)
                        { Console.WriteLine("No matches"); }
                        else
                        { Console.WriteLine(resultMax); }
                        break;
                    case "min":
                        var resultMin = 0;
                        var helpArrMin = input.OrderBy(n => n).Distinct().ToList();
                        if (line[1] == "odd")
                        {
                            var number = helpArrMin.FirstOrDefault(a => a % 2 != 0);
                            resultMin = input.LastIndexOf(input.FindLast(a => a == number));
                        }
                        else if (line[1] == "even")
                        {
                            var number = helpArrMin.FirstOrDefault(a => a % 2 == 0);
                            resultMin = input.LastIndexOf(input.FindLast(a => a == number));
                        };
                        if (resultMin < 0)
                        { Console.WriteLine("No matches"); }
                        else
                        { Console.WriteLine(resultMin); }
                        break;
                    case "first":
                        if (int.Parse(line[1]) > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (line[2] == "odd")
                            {
                                var helpArrOdd = input.FindAll(a => a % 2 != 0).Take(int.Parse(line[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", helpArrOdd)}]");
                            }
                            else if (line[2] == "even")
                            {
                                var helpArrEven = input.FindAll(a => a % 2 == 0).Take(int.Parse(line[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", helpArrEven)}]");
                            }
                        }
                        break;
                    case "last":
                        if (int.Parse(line[1]) > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (line[2] == "odd")
                            {
                                var helpArrOdd = input.FindAll(a => a % 2 != 0).ToList();
                                helpArrOdd.Reverse();
                                var result = helpArrOdd.Take(int.Parse(line[1])).ToList();
                                result.Reverse();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                            else if (line[2] == "even")
                            {
                                var helpArrEven = input.FindAll(a => a % 2 == 0).ToList();
                                helpArrEven.Reverse();
                                var result = helpArrEven.Take(int.Parse(line[1])).ToList();
                                result.Reverse();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }
                        break;
                }
                line = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
