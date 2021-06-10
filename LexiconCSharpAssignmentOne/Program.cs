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
                        Console.WriteLine("Result: " + userInputForPowerOf());
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
            if (decimal.TryParse(stringInputOne, out firstNumber) && decimal.TryParse(stringInputTwo, out secondNumber))
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
                Console.WriteLine("square root of {0} = " + Math.Sqrt(number), number);
            }
            else
            {
                Console.WriteLine("Either {0} isn't a number!", stringInput);
            }
        }

        //////////////////////////OLD
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

        //Take the input from the user and does the checks on those inputs before starting the recursive function to calculate power of
        private static double userInputForPowerOf()
        {
            double numberToBePowered = 0;
            int power = 0;

            //Let's the user input two numbers
            Console.Write("Input the number that is going to be powered(Positiv number): ");
            string stringInputOne = Console.ReadLine();
            Console.Write("Input power (integer, positiv or negativ): ");
            string stringInputPower = Console.ReadLine();

            if (double.TryParse(stringInputOne, out numberToBePowered) && int.TryParse(stringInputPower, out power))
            {
                //If power is above 0 we call powerOfMethod then return the value
                //If power is negativ then we still call powerOfMethod (But change power to positiv)
                ////but we divide 1 by the result and send that back.
                //And if power is 0 we just return 1
                if (power > 0)
                    return powerOfMethod(numberToBePowered, numberToBePowered, --power);
                else if (power < 0)
                    return 1 / powerOfMethod(numberToBePowered, numberToBePowered, ++power * -1);
                else
                    return 1;
            }
            else
            {
                Console.WriteLine("Either {0} or {1} isn't a number!", stringInputOne, stringInputPower);
            }

            return 0.0;
        }

        //Calculate power of but with a recursive function.
        //It recives the current result(starts as numberToBePowered),
        //the number that is going to be powered and power as a count so the function knows when to stop
        private static double powerOfMethod(double currentValue, double numberToBePowered, int count)
        {
            //Multiplicate the current value with numberToBePowered each time the function is called just like with 2^3, 2*2=4*2=8
            currentValue *= numberToBePowered;

            //Reduce count each time so the function knows when to stop
            count--;

            //If count has reached 0, return, if not then the function continues to call itself
            if (count > 0)
            {
                return powerOfMethod(currentValue, numberToBePowered, count);
            }
            else
                return currentValue;
        }
    }
}
