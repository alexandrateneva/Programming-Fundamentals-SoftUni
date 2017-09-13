﻿namespace _10.Centuries_to_Nanoseconds___Exercises
{
    using System;

    public class CenturiesToNanoseconds
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = minutes * 60;
            ulong miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;


            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
