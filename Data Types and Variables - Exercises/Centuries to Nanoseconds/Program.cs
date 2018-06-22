using System;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;
            decimal seconds = (decimal)minutes * 60; 
            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = {seconds * 1000} milliseconds = " +
                $"{seconds * 1000000} microseconds = {seconds*1000000000} nanoseconds");
        }
    }
}
