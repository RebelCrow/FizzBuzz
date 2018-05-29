//FizzBuzz
//Programed by Callum Galbraith
//Last Modified 29/05/18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to fizzbuzz");//confirmation the program has started
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) //if fits both Critera
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)  //if fits divsable by 5
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) //if fits divisable by 3
                {
                    Console.WriteLine("Fizz");
                } 
                else //else print the Numerator
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press Enter to exit the program");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { } //wait for keyboard enter to end the program
        }
    }
}
