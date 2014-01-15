using System;
using System.Globalization;

namespace MyStuff
{
    public class WithFuncType
    {
        public Func<string, string> ToUpper = st => st.ToUpper(CultureInfo.InvariantCulture);
        public Func<int, string> FormatMe = n => string.Format("You entered {0}", n);
        public Func<int, int, string> ToSum = (n, m) => (n + m).ToString(CultureInfo.InvariantCulture);
    }
}
