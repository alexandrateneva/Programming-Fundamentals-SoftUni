﻿namespace _10.Animal_Type
{
    using System;

    public class AnimalType
    {
        public static void Main()
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
