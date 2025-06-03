using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.

        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
               Console.WriteLine(i); 
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        public static void UpbyThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.

        public static void TwoNumbersSame(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same!");
            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not the same!");
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.

        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
                
            else
            {
                Console.WriteLine("Negative");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age");
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats, {userAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
                
            }
            
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.


        public static void TenRange()
        {
            Console.WriteLine("Please give me a number");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"{userNumber} is in the ten range!");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the ten range!");
            }
                
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.

        public static void MultiplyThroughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //UpbyThrees();
            //TwoNumbersSame(1, 2);
            //EvenOrOdd(2);
            //IsPositive(2);
            //CanVote();
            //TenRange();
            //MultiplyThroughTwelve(10);
        }
    }
}
