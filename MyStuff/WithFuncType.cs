using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MyStuff
{
    public class WithFuncType : IWithFuncType
    {
        readonly Func<string, string> _toUpper = st => st.ToUpper(CultureInfo.InvariantCulture);
        readonly Func<int, string> _formatMe = n => string.Format("You entered {0}", n);
        readonly Func<int, int, string> _toSum = (n, m) => string.Format("Sum of {0} and {1} = {2}", n, m, n + m);

        public string FormatNumberAndMakeToUpper(int num)
        {
            return MakeMeInUpperCase(_formatMe.Invoke(num));
        }

        public string GiveMeSumInDefinedFormat(int num1, int num2)
        {
            return _toSum.Invoke(num1, num2);
        }

        public string MakeMeInUpperCase(string stringToUpper)
        {
            return _toUpper.Invoke(stringToUpper);
        }

        public List<string> GiveMeFullNames(IEnumerable<FullName> suppliedNames)
        {
            var fullNames = new List<string>();

            fullNames.AddRange(suppliedNames.Select(fullName => fullName.ToString(NameFormatter)));

            return fullNames;
        }

        private string NameFormatter(FullName stringToFormat)
        {
            var builder = new StringBuilder();

            builder.AppendFormat("{0} {1} {2}", stringToFormat.FirstName,
                stringToFormat.IsMiddleNameSupplied ? stringToFormat.MiddleName : "-", stringToFormat.LastName);

            return builder.ToString();
        }

    }

    public class FullName
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public bool IsMiddleNameSupplied
        {
            get { return !string.IsNullOrEmpty(MiddleName); }
        }

        public string ToString(Func<FullName, string> formatter)
        {
            return formatter(this);
        }
    }
}
