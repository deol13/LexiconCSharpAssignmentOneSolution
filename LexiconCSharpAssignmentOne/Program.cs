using System;

namespace LexiconCSharpAssignmentOne
{
    //////////////////////////////////////////
    //Create a calculator class that just calculate
    //See if generic <T> can/should be added
    //Make a ask/inputFromUser method that is generic enought to be 
    //called everytime we need something from the user, even if
    //what we ask for is completly different. 
    //Use Console.WriteLine("Input {StringWhatWeAskFromUser} ");
    //This way we only need one method for every user input situation.
    //We can save this method and reuse it in other projects!
    //The only problem is where to parse, can't be in main if we want to unit test it
    //
    //What happens if we make Program public? Can we access it from unit tester? If so that will solve the parse problem
    //////////////////////////////////////////
    /*
     * This is how we can show info inside a class without either the class or main being reliant on each other, thus getting loose coupling in both
    public string Info()
    {
        return $"---- Car Info ----\nId: {id}\nBrand: {brand}\nModel: {model}\nColor {color}\nYear: {year}\nHp: {hp}";
    }
    or
    public override string ToString()
    {
        return Info();
    }
    */

    //////////////////////////////////
    //In git changes -> ... -> new branch !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool isAlive = true;
            double num1 = 0;
            double num2 = 0;

            while (isAlive)
            {
                num1 = 0;
                num2 = 0;

                Console.WriteLine("Welcome to my Calculator!\n Please select one of the following functionalities: " +
                    "\n 1: Addition " +
                    "\n 2: Subtraction" +
                    "\n 3: Division" +
                    "\n 4: Multiplication" +
                    "\n 5: Square Roots" +
                    "\n 6: Power of" +
                    "\n 7: Addition on a list of numbers" +
                    "\n 8: Subtraction on a list of numbers" +
                    "\n 99: Exit");

                int.TryParse(Console.ReadLine(), out int userSelection);

                try
                {
                    switch (userSelection)
                    {
                        case 1:
                            Console.Clear();
                            num1 = AskForInputDouble("number");
                            num2 = AskForInputDouble("number");
                            Console.WriteLine(calc.AdditionMethod(num1, num2));
                            break;
                        case 2:
                            Console.Clear();
                            num1 = AskForInputDouble("number");
                            num2 = AskForInputDouble("number");
                            Console.WriteLine(calc.SubstractionMethod(num1, num2));
                            break;
                        case 3:
                            Console.Clear();
                            num1 = AskForInputDouble("numerator");
                            num2 = AskForInputDouble("denominator");
                            Console.WriteLine(calc.DivisionMethod(num1, num2));
                            break;
                        case 4:
                            Console.Clear();
                            num1 = AskForInputDouble("number");
                            num2 = AskForInputDouble("number");
                            Console.WriteLine(calc.MultiplicationMethod(num1, num2));
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine(calc.SquareRootsMethod(AskForInputDouble("number to be squared")));
                            break;
                        case 6:
                            Console.Clear();
                            num1 = AskForInputDouble("number");
                            int power = AskForInputInt("a power");
                            Console.WriteLine("Result: " + UserInputForPowerOf(calc, num1, power));
                            break;
                        case 7:
                            Console.Clear();
                            double[] addNumArr = AskForAnArray("added together");
                            Console.WriteLine(calc.AdditionMethod(addNumArr));
                            break;
                        case 8:
                            Console.Clear();
                            double[] subNumArr = AskForAnArray("substracted together");
                            Console.WriteLine(calc.SubstractionMethod(subNumArr));
                            break;
                        case 99:
                            Console.WriteLine("Thank you for trying out my calculator!");
                            isAlive = false;
                            break;
                        default:
                            Console.WriteLine("Not a valid selection, please try again");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        //Take the input from the user and does the checks on those inputs before starting the recursive function to calculate power of
        public static double UserInputForPowerOf(Calculator calc, double num1, int numPower)
        {
            if (numPower > 0)
                return calc.PowerOfMethod(num1, num1, --numPower);
            else if (numPower < 0)
                return 1 / calc.PowerOfMethod(num1, num1, ++numPower * -1);

            return 1;
        }

        private static double AskForInputDouble(string whatToAsk)
        {
            string outPutAsString = "";
            double number = 0;

            Console.Write($"Input a {whatToAsk} (decimals): ");
            outPutAsString = Console.ReadLine();

            number = double.Parse(outPutAsString);

            return number;
        }

        private static int AskForInputInt(string whatToAsk)
        {
            string outPutAsString = "";
            int number = 0;

            Console.Write($"Input a {whatToAsk} (no decimals): ");
            outPutAsString = Console.ReadLine();

            number = int.Parse(outPutAsString);

            return number;
        }

        private static double[] AskForAnArray(string whatToAsk)
        {
            Console.Write($"Input multiple numbers to be {whatToAsk}: ");
            string str = Console.ReadLine();
            string[] numArrString = str.Split();
            double[] numArr = new double[numArrString.Length];

            for (int i = 0; i < numArrString.Length; i++)
            {
                numArr[i] = double.Parse(numArrString[i]);
            }

            return numArr;
        }
    }
}
