//Name: Gabriel Ramirez
//Date: 10/1/2023
//Description: Find the value of the first term that contains 10 digits in the Fibonacci sequence

using System.Collections.Generic;

namespace CodeChallenges2
{
    internal class TenDigit
    {
        static void Main(string[] args)
        {
           
            //Initilize list to store the incoming string values from the sequence
            List<string> numberList = new List<string>();
           
            //variable used in for loop
            const int MAX = 60;

            //Sum = Sum of Previous sum + The previous sum of the previous Sum
            //F(n) = F(n-1) + F(n-2)
            //0,1,1,2,3,5,8


            int fN1 = 0; //Previous sum
            int fN2 = 1; //Previous sum 2
            int sum = 0; //final sum

            //Sequence using the for loop

            Console.WriteLine(fN1);
            for (int i = 0; i <= MAX; i++)
            {       
                    //cast the int sum into a string and store that in the List       
                    sum = fN1 + fN2;
                    fN2 = fN1;
                    fN1 = sum;
                    numberList.Add(sum.ToString());
                    Console.WriteLine(sum);                 
                      
            }

            //Create a string variable to store the Digit
            string tenDigitTerm = " "; 

            //Using the List find the value of the first term that contains 10 digits
            foreach (string number in numberList)
            {
                //Console.WriteLine(number);
                //Conditional statement to check the character length
                //If the amount of characters is == 10 digits print it out.

                if (number.Length == 10)
                {
                    Console.WriteLine("Number found! " + number);
                    tenDigitTerm = number;
                    break;
                }

            }

            Console.WriteLine("The first term that contains 10 digits is: " + tenDigitTerm);                 
                        

          
        }

    }
}
