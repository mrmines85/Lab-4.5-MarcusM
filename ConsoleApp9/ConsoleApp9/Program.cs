using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scores = new List<string>();
            scores.Add("4400");
            scores.Add("8900");
            scores.Add("1200");
            scores.Add("3700");
            scores.Add("7200");

            scores.Sort();
            foreach (string item in scores)
            {
                Console.WriteLine(item);
            }

            scores.Reverse();
            foreach (string item in scores)
            {
                Console.WriteLine(item);
            }

            scores.Add("2400");

            scores.Remove("4400");
            Console.WriteLine(scores);

        }
    }
}
