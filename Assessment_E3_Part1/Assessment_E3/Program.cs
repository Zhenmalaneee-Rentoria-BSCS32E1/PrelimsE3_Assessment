using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_E3
{
    class Program
    {
        static void Main(string[] args)
        {
            //AREA OF A TRIANGLE

            Console.WriteLine("AREA OF TRIANGLE");

            double num = 0.5; // i converted the 1/2 into decimal
            Console.Write("Please Enter Height: "); // user input
            int height = Convert.ToInt32(Console.ReadLine()); // convert string input into an integer

            Console.Write("Please Enter base: ");  // user input
            int Base = Convert.ToInt32(Console.ReadLine()); // convert string input into an integer

            double area = num * height * Base; // formula to get area of triangle
            Console.WriteLine("The area of a triangle is: " + area); // result
           

            Console.WriteLine("___________________________________________________");
            Console.WriteLine("ARRAY OF 5 INTEGERS");
            // Declare an array of 5 integers
            int[] myArray = new int[5];

            // Fill the array with values based on n^2
            for (int i = 0; i < 5; i++) // will run iteration for 5 times
            {
                Console.Write($" Please enter a number {i + 1}: "); //prompt user input where it displays the current iteration number
                int userInput;
                if (int.TryParse(Console.ReadLine(), out userInput)) //Convert input into integer also reads user input.
                {
                    myArray[i] = userInput * userInput; // will execute if user input was is integer.
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; // index dcrement, if input is string this will allow user to retry input.
                }
            }


            Console.WriteLine("FOR LOOP WITH SQAURE ROOT");
            // Find the largest element
            int maxElem = myArray[0]; // initializes variable maxElem with the value of the first element in the array
            for (int i = 1; i < 5; i++) // loop condition
            {
                if (myArray[i] > maxElem) //if current element is greater than maxElem, updtate maxElem with the current elements value:  maxElem = myArray[i]
                {
                    maxElem = myArray[i];
                }
            }

            // Print the array and the largest element
            Console.WriteLine("\nArray:"); // Prints the word “Array:” followed by a newline.
            foreach (int value in myArray) //Iterates through each element in the myArray array
            {
                Console.Write(value + " "); // Prints the value of the current array element followed by a space.
            }
            Console.WriteLine($"\nLargest element: {maxElem}"); //Prints the largest element found in the array.

            Console.ReadLine();


            Console.WriteLine("___________________________________________________");

            Console.WriteLine("FOR LOOP");
            Console.WriteLine("Number  |  Square Root");
            Console.WriteLine("______________________");

            for (int i = 1; i <= 10; i++) //This loop runs from i = 1 to i = 10.
            {
                double sqrRoot = Math.Sqrt(i); // For each iteration, it calculates the square root of i
                Console.WriteLine($"  {i}     =   {sqrRoot:F4}"); // Formats the output with the number and its square root (rounded to four decimal places).
            }
            Console.WriteLine("______________________");
            Console.ReadLine();

        }
    }
}
