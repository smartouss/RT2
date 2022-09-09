using RT2.FizzBuzz;
using System;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FizzBuzzTool.Evaluate(100 , new Dictionary<int, string>() 
            {
                {2 ,"fizz" },
                {4,"buzz" },
                {6,"ozz" }
            });

            result.PrintToConsole();
        }
    }
}
