/* Define an integer array that will hold 10 integers. Initialize it with the following values: 56, 77, 23, 12, 88, 59, 97, 33, 38, 64.
Define a string array that will hold 10 strings.

// Write a function, named findMax, that will accept two arguments and return an integer value. The first parameter is an integer array. 
// The second parameter is the size or length of the integer array. Loop through the positions in the array,
// searching all items to find the largest value in the array.
//  Return the array index of the largest value found.


Write a function named, evenOrOdd, that will accept three parameters. The first parameter is the integer array used in the above function. 
The second parameter is the string array from step 2 and the third parameter is an integer indicating the size of the two arrays.
 This function will perform the following tasks:
This function will loop through the first array, checking each value to see if it is even or odd.

For each item in the integer array, the function will then place the appropriate value, “even” or “odd”, in the corresponding position of the string array.
 Hint: Using the modulus operator, (also called the modulo), to divide the number by 2 will result in either a remainder of 0 or 1. A remainder of 
 0 indicates an even number and a remainder of 1 indicates an odd number. 


After calling both functions, print the maximum number determined by findMax as well as the array index position of the largest number.
Next, the program will loop through the two arrays and print the integer from integer array 
followed by the corresponding “even” or “odd” value from the string array. */

//arrayOfNumbers.Length().......Contains().......[]index locator......IndexOf( ' ')
//
//math.Max (4, 90) .....will return larger number its a method, maybe I can use this
//........Substring()


using System;

namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                                                                                            // Define an integer array that will hold 10 integers
            int[] intArray = new int[] { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };

                                                                                                                                                            // Define a string array that will hold 10 strings
            string[] stringArray = new string[10];

                                                                                                                                                            // Write a function, named findMax, that will accept two arguments and return an integer value
            int findMax(int[] arr, int size)
            {
                int maxValue = arr[0];
                int maxIndex = 0;
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] > maxValue)
                    {
                        maxValue = arr[i];
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }

                                                                                                                                                             // Write a function named, evenOrOdd, that will accept three parameters
            void evenOrOdd(int[] intArray, string[] stringArray, int size)
            {
                                                                                                                                                            // This function will loop through the first array, checking each value to see if it is even or odd
                for (int i = 0; i < size; i++)
                {
                    stringArray[i] = (intArray[i] % 2 == 0) ? "even" : "odd";                                                 // For each item in the integer array, the function will then place the appropriate value, “even” or “odd”, in the corresponding position of the string array
                }   
            }    
            

                                                                                                                                                            // Call the findMax function
            int maxIndex = findMax(intArray, intArray.Length);
            Console.WriteLine("The maximum number is: " + intArray[maxIndex]);
            Console.WriteLine("The array index position of the largest number is: " + maxIndex);

                                                                                                                                                             // Call the evenOrOdd function
            evenOrOdd(intArray, stringArray, intArray.Length);

                                                                                                                                                            // Print the integer from integer array followed by the corresponding “even” or “odd” value from the string array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i] + " is " + stringArray[i]);
            }
        }
    }
}

