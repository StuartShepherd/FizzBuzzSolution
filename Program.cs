// C# Implementation of FizzBuzz. 
// Fizz buzz (often spelled FizzBuzz in this context) has been used as an interview screening device for computer programmers. 
// Writing a program to output the first 100 FizzBuzz numbers is a trivial problem for any would-be computer programmer, 
// so interviewers can easily sort out those with insufficient programming ability.

using System;

namespace FizzBuzzSolution
{
    class Program
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";

        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Solution");
            Console.WriteLine("");

            for (int i = 1; i <= 100; i++)
            {
                var output = "";

                if (i % 15 == 0)
                {
                    output = FizzBuzz;
                }
                else if (i % 3 == 0)
                {
                    output = Fizz;
                }
                else if (i % 5 == 0)
                {
                    output = Buzz;
                }
                else
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }

            Console.ReadLine();
        }

    }
}