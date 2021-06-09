using System;

namespace LexiconCSharpAssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;

            while (isAlive)
            {
                Console.WriteLine("Welcome to my Calculator!\n Please select one of the following functionalities: " +
                    "\n 1: Addition " +
                    "\n 2: Subtraction" +
                    "\n 3: Division" +
                    "\n 4: Multiplication" +
                    "\n 5: Square Roots" +
                    "\n 6: Power of" +   
                    "\n 99: Exit");

                int.TryParse(Console.ReadLine(), out int userSelection);

                switch (userSelection)
                {
                    case 1:
                        Console.Clear();
                        additionMethod();
                        break;
                    case 2:
                        Console.Clear();
                        substractionMethod();
                        break;
                    case 3:
                        Console.Clear();
                        divisionMethod();
                        break;
                    case 4:
                        Console.Clear();
                        multiplicationMethod();
                        break;
                    case 5:
                        Console.Clear();
                        squareRootsMethod();
                        break;
                    case 6:
                        Console.Clear();
                        powerOfMethod();
                        break;
                    case 99:
                        Console.WriteLine("Thank you for trying out my calculator!");
                        isAlive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid selection, please try again");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        //Waits for the user to input two numbers then adds them together
        private static void additionMethod()
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;

            //Let's the user input two numbers
            Console.Write("Input the first number: ");
            string stringInputOne = Console.ReadLine();
            Console.Write("Input the second number: ");
            string stringInputTwo = Console.ReadLine();

            //int.TryParse returns true or false depending on if it could parse the string to an int
            //So we use that to see if both inputs are infact numbers. 
            if(decimal.TryParse(stringInputOne, out firstNumber) && decimal.TryParse(stringInputTwo, out secondNumber))
            {
                //Add them together directly in the writeline because there is no need to save the results
                Console.WriteLine("{0} + {1} = " + (firstNumber + secondNumber), firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringInputOne, stringInputTwo);
            }
        }

        //Waits for the user to input two numbers then substracts them together
        private static void substractionMethod()
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;

            //Let's the user input two numbers
            Console.Write("Input the first number: ");
            string stringInputOne = Console.ReadLine();
            Console.Write("Input the second number: ");
            string stringInputTwo = Console.ReadLine();

            if (decimal.TryParse(stringInputOne, out firstNumber) && decimal.TryParse(stringInputTwo, out secondNumber))
            {
                //Substract them directly in the writeline because there is no need to save the results
                Console.WriteLine("{0} - {1} = " + (firstNumber - secondNumber), firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringInputOne, stringInputTwo);
            }
        }

        //Waits for the user to input two numbers then divides them together
        private static void divisionMethod()
        {
            decimal numeratorNumber = 0;
            decimal denominatorNumber = 0;

            //Let's the user input two numbers
            Console.Write("Input the numerator: ");
            string stringNumerator = Console.ReadLine();
            Console.Write("Input the denominator: ");
            string stringDenominator = Console.ReadLine();

            if (decimal.TryParse(stringNumerator, out numeratorNumber) && decimal.TryParse(stringDenominator, out denominatorNumber))
            {
                //Quick check if either number is a 0
                if (numeratorNumber != 0 && denominatorNumber != 0)
                {
                    Console.WriteLine("{0} / {1} = " + (numeratorNumber / denominatorNumber), numeratorNumber, denominatorNumber);
                }
                else
                {
                    Console.WriteLine("Error: You tried to divied with 0!");
                }
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringNumerator, stringDenominator);
            }
        }

        //Waits for the user to input two numbers then multiplicate them together
        private static void multiplicationMethod()
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;

            //Let's the user input two numbers
            Console.Write("Input the first number: ");
            string stringInputOne = Console.ReadLine();
            Console.Write("Input the second number: ");
            string stringInputTwo = Console.ReadLine();

            if (decimal.TryParse(stringInputOne, out firstNumber) && decimal.TryParse(stringInputTwo, out secondNumber))
            {
                //Multiplicates them together directly in the writeline because there is no need to save the results
                Console.WriteLine("{0} * {1} = " + (firstNumber * secondNumber), firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringInputOne, stringInputTwo);
            }
        }

        //Takes one input from the user then square roots it
        private static void squareRootsMethod()
        {
            double number = 0;

            //Let's the user input a number
            Console.Write("Input a number: ");
            string stringInput = Console.ReadLine();

            if (double.TryParse(stringInput, out number))
            {
                //Square root it directly in the writeline because there is no need to save the results
                Console.WriteLine("square root of {0} = " + Math.Sqrt(number), number );
            }
            else
            {
                Console.WriteLine("Either {0} isn't a number!", stringInput);
            }
        }

        //Takes two numbers from the user, the number that will be powered and the power.
        //Then Math.pow them.
        private static void powerOfMethod()
        {
            double numberToBePowered = 0;
            double power = 0;

            //Let's the user input two numbers
            Console.Write("Input the number that is going to be powered: ");
            string stringInputOne = Console.ReadLine();
            Console.Write("Input power: ");
            string stringInputPower = Console.ReadLine();

            if (double.TryParse(stringInputOne, out numberToBePowered) && double.TryParse(stringInputPower, out power))
            {
                //Math.pow directly in the writeline because there is no need to save the results
                Console.WriteLine("{0}^{1} = " + Math.Pow(numberToBePowered, power), numberToBePowered, power);
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringInputOne, stringInputPower);
            }
        }
    }
}
