using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize variables
            string catName = "Nala";
            char nickName = 'T';
            bool lovesTreats = true;
            double catToys = 16;
            decimal weight = 12.8m;

            //string interpolation
            Console.WriteLine($"Let me introduce you to my cat, {catName}, but sometimes we call her {nickName} which is short for Teddy, her middle name. She enjoys playing with her many cat toys, {catToys} to be exact and especially loves her treats, it's {lovesTreats}. That's probably why her chunky self is {weight}lbs, but we" +
                $"re working on it!");
        }
    }
}
