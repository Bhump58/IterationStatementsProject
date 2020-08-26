using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            var num = 0;


            // Create a do-while loop
            
            do {
                
                num++;
                numbers.Add(num);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            } while (num < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while(num < 200){
                num++;
                numbers.Add(num);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            
            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            /*
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            */

            // Create a for loop
            for(var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }

            
        }
    }
}
