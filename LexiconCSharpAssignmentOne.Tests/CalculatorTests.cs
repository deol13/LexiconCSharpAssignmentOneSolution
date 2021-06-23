using System;
using Xunit;
using LexiconCSharpAssignmentOne;

namespace LexiconCSharpAssignmentOne.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(24, 52)]
        [InlineData(125, 356)]
        [InlineData(123451, 723523)]
        [InlineData(-125423, -45234)]
        [InlineData(-1235.53, 235233)]
        [InlineData(1235.53, 2233.5332)]
        public void AdditionValidResult(double num1, double num2)
        {
            //Arrange
            double expectedResult = num1 + num2;
            Calculator calc = new Calculator();
            
            //Act
            double result = calc.AdditionMethod(num1, num2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(24, 52)]
        [InlineData(125, 356)]
        [InlineData(123451, 723523)]
        [InlineData(-125423, -45234)]
        [InlineData(-1235.53, 235233)]
        [InlineData(1235.53, 2233.5332)]
        public void SubstractionValidResult(double num1, double num2)
        {
            //Arrange
            double expectedResult = num1 - num2;
            Calculator calc = new Calculator();

            //Act
            double result = calc.SubstractionMethod(num1, num2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(24, 52)]
        [InlineData(842, 41)]
        [InlineData(-2400, 52)]
        [InlineData(2400, -52)]
        [InlineData(-74, 520)]
        [InlineData(89, -5200)]
        public void DivisonValidResult(double num1, double num2)
        {
            //Arrange
            double expectedResult = num1 / num2;
            Calculator calc = new Calculator();

            //Act
            double result = calc.DivisionMethod(num1, num2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void DivisonThrowDivideByZeroException()
        {
            //Arrange
            double num1 = 23412;
            double num2 = 0;
            double expectedResult = num1 / num2;
            Calculator calc = new Calculator();

            //Act
            DivideByZeroException result = Assert.Throws<DivideByZeroException>(() => calc.DivisionMethod(num1, num2));

            //Assert
            Assert.Equal("Attempted to divide by zero.", result.Message);
        }

        [Theory]
        [InlineData(24, 52.4)]
        [InlineData(12.5, 356)]
        [InlineData(123451, 723523.78)]
        [InlineData(-125423, -45234.34)]
        [InlineData(-1235.53, 235233)]
        [InlineData(1235.53, 2233.5332)]
        [InlineData(1235.53, 0)]
        [InlineData(0, 2341)]
        public void MultiplicationValidResult(double num1, double num2)
        {
            //Arrange
            double expectedResult = num1 * num2;
            Calculator calc = new Calculator();

            //Act
            double result = calc.MultiplicationMethod(num1, num2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(224)]
        [InlineData(1312.5)]
        [InlineData(1252)]
        [InlineData(-520)]
        [InlineData(52)]
        [InlineData(0)]
        public void SquareRootValidResult(double num1)
        {
            //Assign
            double expectedResult = Math.Sqrt(num1);
            Calculator calc = new Calculator();

            //Act
            double result = calc.SquareRootsMethod(num1);

            //Assert
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData(24, 2)]
        [InlineData(-12.5, 7)]
        [InlineData(6, 15)]
        [InlineData(11, 5)]
        [InlineData(8, 11)]
        [InlineData(-52, 6)]
        [InlineData(5, 8)]
        [InlineData(8, 15)]
        [InlineData(12, 35)]
        [InlineData(9, 20)]
        public void PowerOfMethodPositivPower(double num1, int power)
        {
            //Assign
            double expectedResult = Math.Pow(num1, power);
            Calculator calc = new Calculator();

            //Act
            double result = calc.PowerOfMethod(num1, power);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(53, -2)]
        [InlineData(-16.5, -6)] //Rounding differently
        [InlineData(8, -15)]
        [InlineData(-62, -4)]
        [InlineData(32, -9)]
        [InlineData(2, -14)]
        [InlineData(5, -6)]
        [InlineData(9, -9)]
        public void PowerOfMethodNegativPower(double num1, int power)
        {
            //Assign
            double expectedResult = Math.Pow(num1, power);
            Calculator calc = new Calculator();

            //Act
            double result = calc.PowerOfMethod(num1, power);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void PowerOfMethodZeroAsPower()
        {
            double num1 = 2342;
            int power = 0;
            //Assign
            double expectedResult = Math.Pow(num1, power);
            Calculator calc = new Calculator();

            //Act
            double result = calc.PowerOfMethod(num1, power);

            //Assert
            Assert.Equal(expectedResult, result);
        }


        [Fact]
        public void AdditionArrayValidResult()
        {
            //Assign
            double[] arr = new double[] { 41, 111, 65, -100, 55, 12, -23};
            Calculator calc = new Calculator();
            double expectedResult = 0;

            //Act
            double result = calc.AdditionMethod(arr);
            foreach (double num in arr)
            {
                expectedResult += num;
            }

            //Assert
            Assert.Equal(expectedResult, result);

        }
        [Fact]
        public void AdditionArrayValidResult_DifferentSizeArr()
        {
            //Assign
            double[] arr = new double[] { 41.734, 111, 65.5, -100, 55, 12, -23.5, 124.5, -123.67, 42, 123 };
            Calculator calc = new Calculator();
            double expectedResult = 0;

            //Act
            double result = calc.AdditionMethod(arr);
            foreach (double num in arr)
            {
                expectedResult += num;
            }

            //Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void AdditionArrayLengthZeroThrowException()
        {
            //Arrange
            double[] arr = new double[0];
            Calculator calc = new Calculator();
            double expectedResult = 342;

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => calc.AdditionMethod(arr));

            //Assert
            Assert.Equal("No numbers were inputed to addition on a list.", result.Message);
        }
        
        
        [Fact]
        public void SubstractionArrayValidResult()
        {
            //Assign
            double[] arr = new double[] { 441, 842, 615, -923, 155, 612, -223 };
            Calculator calc = new Calculator();
            double expectedResult = 0;

            //Act
            double result = calc.SubstractionMethod(arr);

            expectedResult = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                expectedResult -= arr[i];
            }

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void SubstractionArrayValidResult_DifferntSizeArr()
        {
            //Assign
            double[] arr = new double[] { 155.6, 612, -223, 235, 0, -123 };
            Calculator calc = new Calculator();
            double expectedResult = 0;

            //Act
            double result = calc.SubstractionMethod(arr);

            expectedResult = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                expectedResult -= arr[i];
            }

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SubstractionArrayLengthZeroThrowException()
        {
            //Arrange
            double[] arr = new double[0];
            Calculator calc = new Calculator();

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => calc.SubstractionMethod(arr));

            //Assert
            Assert.Equal("No numbers were inputed to substraction on a list.", result.Message);
        }
    }
}
