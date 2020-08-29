using System;
using System.Collections.Generic;

namespace MyStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            StuffWithFuncType();
            Console.ReadLine();

            StuffWithoutFuncType();
            Console.ReadLine();
        }

        private static void StuffWithoutFuncType()
        {
            IWithoutFuncType withoutFuncType = new WithoutFuncType();

            Console.WriteLine(withoutFuncType.ToUpper("this is without func type"));
            Console.WriteLine();
            Console.WriteLine(withoutFuncType.FormatMe(109));
            Console.WriteLine(withoutFuncType.ToSum(101, 9));
        }

        private static void StuffWithFuncType()
        {
            IWithFuncType withFuncType = new WithFuncType();
            Console.WriteLine(withFuncType.MakeMeInUpperCase("this is with func type"));
            Console.WriteLine();
            Console.WriteLine(withFuncType.FormatNumberAndMakeToUpper(109));
            Console.WriteLine(withFuncType.GiveMeSumInDefinedFormat(101, 9));

            //This is a typical example to use of Func Type

            var fullName = GetSomeFullNames();
            var names = withFuncType.GiveMeFullNames(fullName);
            Console.WriteLine();
            Console.WriteLine("A typical use of Func Type");
            Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine("Full Name: {0}", name);
            }

        }

        private static IEnumerable<FullName> GetSomeFullNames()
        {
            return new List<FullName>
            {
                new FullName
                {
                    FirstName = "Gaurav",
                    MiddleName = "Kumar",
                    LastName = "Arora"
                },

                new FullName
                {
                    FirstName = "Joseph",
                    MiddleName = "",
                    LastName = "Bulger"
                },
                new FullName
                {
                    FirstName = "Shuby",
                    MiddleName = "",
                    LastName = "Arora"
                }
            };
        }
    }
}
