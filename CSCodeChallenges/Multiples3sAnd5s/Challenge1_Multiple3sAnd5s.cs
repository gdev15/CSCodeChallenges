/*
 Name: Gabriel Ramirez
 Date: 9/29/2023
 Description: Challenge to calculate the sum of all multiples of 3 or 5 that is below 1000
 */

using System.Collections.Specialized;

namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            const int MAX = 1000;
            int multiplesOfThree = 3;
            int multiplesOfFive = 5;

            //Find the sum of all multiples of 3 or 5 below 1000

            //First find the multiples of 3 up to 1000


            //int variable to store the sum of all multiples of 3 up to 1000
            int sumOfThrees = 0;
            
            //For loop to iterate by 3 up to 1000    
            for(int i =0; i <= MAX; i+=3)
            {
                sumOfThrees += i;               
            }

            //int variable to store the sum of all multiples of 5 up to 1000
            int sumOfFive = 0;
            //For loop to iterate by 5 up to 1000    
            for (int i = 0; i <= MAX; i += 5)
            {
                sumOfFive += i;               
            }

            Console.WriteLine($"The total sum of all multiples of 3 up to 1000 is: {sumOfThrees:n0}\n");

            Console.WriteLine($"The total sum of all multiples of 5 up to 1000 is: {sumOfFive:n0}\n");

            //calculate all multiples
            int totalSum = sumOfFive + sumOfThrees;
            Console.WriteLine($"The sum of all multiples of 3 or 5 that is below 1000 is: {totalSum:n0}");
        }
    }
}