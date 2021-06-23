using System;
using System.Collections.Generic;
using System.Text;

namespace LexiconCSharpAssignmentOne
{
    public class Calculator
    {
        public double AdditionMethod(double num1, double num2)
        {
            return num1 + num2;
        }
        
        public double AdditionMethod(double[] numbers)
        {
            double totalValue = 0;

            if (numbers.Length > 0)
            {
                foreach (double num in numbers)
                {
                    totalValue += num;
                }
            }
            else
                throw new ArgumentException("No numbers were inputed to addition on a list");

            return totalValue;
        }

        public double SubstractionMethod(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double SubstractionMethod(double[] numbers)
        {
            double totalValue = 0;

            if (numbers.Length > 0)
            {
                totalValue = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    totalValue -= numbers[i];
                }
            }
            else
                throw new ArgumentException("No numbers were inputed to substraction on a list");
             return totalValue;
        }

        //Waits for the user to input two numbers then divides them together
        public double DivisionMethod(double num1, double num2)
        {
            double totalValue = 0;

            if (!num2.Equals(0))
                totalValue = num1 / num2;
            else
                throw new DivideByZeroException();

            return totalValue;
        }

        //Waits for the user to input two numbers then multiplicate them together
        public double MultiplicationMethod(double num1, double num2)
        {
            return num1*num2;
        }

        //Takes one input from the user then square roots it
        public double SquareRootsMethod(double number)
        {
            return Math.Sqrt(number);
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

        /// <summary>
        /// Starting function for PowerOfMethod, here we handle if power is 0 or negativ
        /// </summary>
        /// <param name="num">The number that is to be powered</param>
        /// <param name="numPower">The power</param>
        /// <returns></returns>
        public double PowerOfMethod(double num, int numPower)
        {
            if (numPower > 0)
            {
                //if power is positiv, we reduce power by one then send it in as a counter
                //We reduce it because the method will continue to long otherwise
                //Example: power 2 will cause the method to call itself twice thus return 8
                //instead of just do it once and return 4
                return PowerOfMethod(num, num, --numPower);
            }
            else if (numPower < 0)
            {
                //If power is negativ we call the same powerOfMethod as positiv, but we add
                //we change it to positiv so the method works and increase power by 1 otherwise
                //it will not call itself enough times.
                //Then to get the result a negativ power should get we divide 1 by the result.
                return 1 / PowerOfMethod(num, num, ++numPower * -1);
            }
            //If power is 0 we return 1
            return 1;
        }

        /// <summary>
        /// Calculate power of but with a recursive function.
        /// It recives the current result(starts as numberToBePowered),
        /// the number that is going to be powered and power as a count so the function knows when to stop
        /// </summary>
        /// <param name="currentValue">Contains the current results. Will be returned to the caller.</param>
        /// <param name="numberToBePowered">Number to be powred</param>
        /// <param name="count">Power but used as counter for how long the recursive method will continue</param>
        /// <returns></returns>
        private double PowerOfMethod(double currentValue, double numberToBePowered, int count)
        {
            //Multiplicate the current value with numberToBePowered each time the function is called just like with 2^3, 2*2=4*2=8
            currentValue *= numberToBePowered;

            //Reduce count each time so the function knows when to stop
            count--;

            //If count has reached 0, return, if not then the function continues to call itself
            //If count is larger than 0, go through normal power to by multiplicate with the numerToBePowered.
            if (count > 0)
            {
                return PowerOfMethod(currentValue, numberToBePowered, count);
            }          

            return currentValue;
        }
    }
}
