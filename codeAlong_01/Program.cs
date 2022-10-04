// See https://aka.ms/new-console-template for more information
using System;

namespace CodeAlong_01
{
    class Program
    {
        static void Main(string[] args) {
            //  I want to print to the console my name and age
            //  and a brief description of myself

            string myName = " Marcus";

            int marcusAge = 25;

            string marcusJob = " softwareDeveloper ";

            string funFact = "Marcus absolutely loves swimming!";

            Console.WriteLine($"my name is {myName}, I am {marcusAge} years old. For a living I am a {marcusJob}. Lastly a fun fact: {funFact}");



        }
    }
}
