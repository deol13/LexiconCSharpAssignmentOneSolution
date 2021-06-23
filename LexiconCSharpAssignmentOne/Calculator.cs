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
                throw new IndexOutOfRangeException("No numbers were inputed to addition on a list");

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
                throw new IndexOutOfRangeException("No numbers were inputed to substraction on a list");
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

        public double StartPowerOfMethod(double currentValue, double numberToBePowered, int count)
        {
            if (count.Equals(0))
                return 1;
            return PowerOfMethod(currentValue, numberToBePowered, count);
        }

        //Calculate power of but with a recursive function.
        //It recives the current result(starts as numberToBePowered),
        //the number that is going to be powered and power as a count so the function knows when to stop
        public double PowerOfMethod(double currentValue, double numberToBePowered, int count)
        {
            //If count has reached 0, return, if not then the function continues to call itself
            //If count is larger than 0, go through normal power to by multiplicate with the numerToBePowered.
            if (count > 0)
            {
                //Multiplicate the current value with numberToBePowered each time the function is called just like with 2^3, 2*2=4*2=8
                currentValue *= numberToBePowered;

                //Reduce count each time so the function knows when to stop
                count--;

                return PowerOfMethod(currentValue, numberToBePowered, count);
            }
            //If count is less than 0, then we need to divide instead with numberToBePowered
            else if(count < 0)
            {
                currentValue /= numberToBePowered;

                count++;
            }                

            return currentValue;
        }
    }
}
