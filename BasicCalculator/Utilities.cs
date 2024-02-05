using BasicCalculator.Domain.CalculatorManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Utilities
    {
        internal static void ProgramMenu()
        {
            Console.WriteLine("Welcome! This is a BASIC CALCULATOR");
            string? userSelection;
            do
            {

                Console.WriteLine("Select the Operation you want to perform");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Square Root");
                Console.WriteLine("6: Cube Root \n");
                Console.WriteLine("0: Close Application");

                Console.Write("Your Selection: ");
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        AdditionCalculation();
                        break;
                    case "2":
                        SubtractionCalculation();
                        break;
                    case "3":
                        MultiplicationCalculation();
                        break;
                    case "4":
                        DivisionCalculation();
                        break;
                    case "5":
                        SquareRootCalculation();
                        break;
                    case "6":
                        CubeRootCalculation();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            } 
            while(userSelection != "0");
            
        }

        private static double GetValidNumber(string prompt)
        {
            double number;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                isValid = double.TryParse(userInput, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValid);

            return number;
        }

        public static void AdditionCalculation()
        {
            double inputOne = GetValidNumber("Enter first number: ");
            double inputTwo = GetValidNumber("Enter Second number: ");
            double result;

            Calculate addition = new Calculate();
            result = addition.Addition(inputOne, inputTwo);

            Console.WriteLine($"Your result: {inputOne} + {inputTwo} = {result}");
        }

        public static void SubtractionCalculation()
        {
            double inputOne = 0;
            double inputTwo = 0;
            double result;

            Console.WriteLine("Enter first number: ");
            inputOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            inputTwo = Convert.ToDouble(Console.ReadLine());

            Calculate addition = new Calculate();
            result = addition.Subtraction(inputOne, inputTwo);

            Console.WriteLine($"Your result: {inputOne} - {inputTwo} = {result}");
        }

        public static void MultiplicationCalculation()
        {
            double inputOne = 0;
            double inputTwo = 0;
            double result;

            Console.WriteLine("Enter first number: ");
            inputOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            inputTwo = Convert.ToDouble(Console.ReadLine());

            Calculate addition = new Calculate();
            result = addition.Multiplication(inputOne, inputTwo);

            Console.WriteLine($"Your result: {inputOne} x {inputTwo} = {result}");
        }

        public static void DivisionCalculation()
        {
            double inputOne = 0;
            double inputTwo = 0;
            double result;

            Console.WriteLine("Enter first number: ");
            inputOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            inputTwo = Convert.ToDouble(Console.ReadLine());

            Calculate addition = new Calculate();
            result = addition.Division(inputOne, inputTwo);

            Console.WriteLine($"Your result: {inputOne} / {inputTwo} = {result}");
        }

        public static void SquareRootCalculation()
        {
            double inputOne = 0;

            double result;

            Console.WriteLine("Enter number: ");
            inputOne = Convert.ToDouble(Console.ReadLine());

            Calculate addition = new Calculate();
            result = addition.SquareRoot(inputOne);

            Console.WriteLine($"Your result: Sqrt of {inputOne} = {result}");
        }

        public static void CubeRootCalculation()
        {
            double inputTwo = 0;
            double result;

            Console.WriteLine("Enter number: ");
            inputTwo = Convert.ToDouble(Console.ReadLine());

            Calculate addition = new Calculate();
            result = addition.CubeRoot(inputTwo);

            Console.WriteLine($"Your result: Sqrt of {inputTwo} = {result}");
        }
    }
}
