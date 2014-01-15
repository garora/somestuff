using System.Collections.Generic;

namespace MyStuff
{
    public interface IWithFuncType
    {
        string FormatNumberAndMakeToUpper(int num);
        string GiveMeSumInDefinedFormat(int num1, int num2);
        string MakeMeInUpperCase(string stringToUpper);

        List<string> GiveMeFullNames(IEnumerable<FullName> suppliedNames);
    }
}