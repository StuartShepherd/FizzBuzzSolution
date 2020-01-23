// C# Implementation of FizzBuzz. 
// Fizz buzz (often spelled FizzBuzz in this context) has been used as an interview screening device for computer programmers. 
// Writing a program to output the first 100 FizzBuzz numbers is a trivial problem for any would-be computer programmer, 
// so interviewers can easily sort out those with insufficient programming ability.
//
// The programming assignment is as follows:
// Write a program that prints the numbers from 1 to 100. 
// But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
// For numbers which are multiples of both three and five print "FizzBuzz".

using System;

namespace FizzBuzzSolution
{
    class Program
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Solution");
            Console.WriteLine("");

            for (int i = 1; i <= 100; i++)
            {
                var output = "";

                if (i % 3 == 0)
                    output += Fizz;

                if (i % 5 == 0)
                    output += Buzz;

                if (String.IsNullOrWhiteSpace(output))
                    output = i.ToString();

                Console.WriteLine(output);
            }

            Console.ReadLine();
        }

    }
}