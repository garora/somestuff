using System;
using System.Globalization;

namespace MyStuff
{
    public class WithoutFuncType : IWithoutFuncType
    {
        public string ToUpper(string textToUpper)
        {
            return textToUpper.ToUpper(CultureInfo.InvariantCulture);
        }

        public string FormatMe(int number)
        {
            return String.Format("You entered {0}.", number);
        }

        public string ToSum(int firstNumber, int secondNumber)
        {
            return string.Format("Sum of {0} and {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
        }
    }
}
