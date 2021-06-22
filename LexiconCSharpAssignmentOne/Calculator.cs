using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconCSharpAssignmentOne
{
    public class Calculator
    {
        public string AdditionMethod(double num1, double num2)
        {
            //Add them together directly in the writeline because there is no need to save the results
            string output = $"{num1} + {num2} = " + (num1 + num2);

            return output;
        }
        
        public string AdditionMethod(double[] numbers)
        {
            double totalValue = 0;
            string output = "";

            if (numbers.Length > 0)
            {
                output = numbers[0].ToString();
                totalValue = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    output += $" + {numbers[i]}";
                    totalValue += numbers[i];
                }
                output += $" = {totalValue}";
            }
            else
                throw new IndexOutOfRangeException("No numbers were inputed to addition on a list");

            return output;
        }

        public string SubstractionMethod(double num1, double num2)
        {
            //Substract them directly in a string because there is no need to save the results
            string output = $"{num1} - {num2} = " + (num1 - num2);

            return output;
        }
        
        public string SubstractionMethod(double[] numbers)
        {
            double totalValue = 0;
            string output = "";

            if (numbers.Length > 0)
            {
                output = numbers[0].ToString();
                totalValue = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    output += $" - {numbers[i]}";
                    totalValue -= numbers[i];
                }
                output += $" = {totalValue}";
            }
            else
                throw new IndexOutOfRangeException("No numbers were inputed to substraction on a list");

            return output;
        }

        //Waits for the user to input two numbers then divides them together
        public string DivisionMethod(double num1, double num2)
        {
            string output;
            if (!num2.Equals(0))
                output = $"{num1} / {num2} = " + (num1 / num2);
            else
                throw new DivideByZeroException();

            return output;
        }

        //Waits for the user to input two numbers then multiplicate them together
        public string MultiplicationMethod(double num1, double num2)
        {
            //Multiplicates them together directly in the writeline because there is no need to save the results
            string output = $"{num1} * {num2} = " + (num1 * num2);

            return output;
        }

        //Takes one input from the user then square roots it
        public string SquareRootsMethod(double number)
        {
            string outPutAsString = "";

            //Square root it directly to a string because there is no need to save the results
            outPutAsString = $"square root of {number} = " + Math.Sqrt(number);
            
            return outPutAsString;
        }

        /*
        //Takes two numbers from the user, the number that will be powered and the power.
        //Then Math.pow them.
        public void PowerOfMethod()
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
        */

        //Calculate power of but with a recursive function.
        //It recives the current result(starts as numberToBePowered),
        //the number that is going to be powered and power as a count so the function knows when to stop
        public double PowerOfMethod(double currentValue, double numberToBePowered, int count)
        {
            //Multiplicate the current value with numberToBePowered each time the function is called just like with 2^3, 2*2=4*2=8
            currentValue *= numberToBePowered;

            //Reduce count each time so the function knows when to stop
            count--;

            //If count has reached 0, return, if not then the function continues to call itself
            if (count > 0)
            {
                return PowerOfMethod(currentValue, numberToBePowered, count);
            }
            else
                return currentValue;
        }
    }
}
