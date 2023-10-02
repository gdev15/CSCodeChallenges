//Name: Gabriel Ramirez
//Date: 10/1/2023
//Description: Prints out the Fibonacci Even Sum sequence

using System;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;

namespace CodeChallenges2
{
    internal class EvenSum
    {
        static void Main(string[] args)
        {
            //variable used in for loop
            const int MAX = 20;

            //Sum = Sum of Previous sum + The previous sum of the previous Sum
            //F(n) = F(n-1) + F(n-2)
            //0,1,1,2,3,5,8

        
            int fN1 = 0; //Previous sum
            int fN2 = 1; //Previous sum 2
            int sum = 0; //final sum

            //Sequence using the for loop

            /*Console.WriteLine(fN1);
            for (int i = 0; i < MAX; i++)
            {  
             
                    sum = fN1 + fN2;
                    fN2 = fN1;
                    fN1 = sum;
                    Console.WriteLine(sum);
                
                                      
            }*/

            Console.WriteLine("Printing the sequence up to a specifice value");

            while(sum <= 4000000)
            {
                sum = fN1 + fN2;
                fN2 = fN1;
                fN1 = sum;
                Console.WriteLine(sum);
            }

              
                  
                       
        }
    }
}