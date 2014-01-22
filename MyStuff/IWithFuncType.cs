using System.Collections.Generic;

namespace MyStuff
{
    public interface IWithFuncType
    {
        string FormatNumberAndMakeToUpper(int number);
        string GiveMeSumInDefinedFormat(int firstNumber, int secondNumber);
        string MakeMeInUpperCase(string stringToUpper);

        List<string> GiveMeFullNames(IEnumerable<FullName> suppliedNames);
    }
}