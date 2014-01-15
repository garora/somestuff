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

        public string FormatMe(int num)
        {
            return String.Format("You entered {0}.", num);
        }

        public string ToSum(int num1, int num2)
        {
            return string.Format("Sum of {0} and {1} = {2}", num1, num2, num1 + num2);
        }
    }
}
