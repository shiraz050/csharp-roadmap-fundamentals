using System;
using System.Collections.Generic;
using System.Text;

namespace _01_types.Examples
{
    public static class StringImmutabilityExample
    {
        public static void Run()
        {
            Console.WriteLine("--- String Immutability Example ---");

            string original = "Hello";
            string modified = original;

            modified += " World"; // this does NOT change 'original'
                                  // it creates a brand new string object

            Console.WriteLine($"original: {original}"); // still "Hello"
            Console.WriteLine($"modified: {modified}");  // "Hello World"

            Console.WriteLine();
            Console.WriteLine("--- Reference Equality vs Value Equality ---");

            string a = "test";
            string b = "test";
            string c = new string("test".ToCharArray());

            Console.WriteLine($"a == b: {a == b}");                     // true (value equality)
            Console.WriteLine($"ReferenceEquals(a, b): {ReferenceEquals(a, b)}"); // true (string interning)
            Console.WriteLine($"ReferenceEquals(a, c): {ReferenceEquals(a, c)}"); // false (different object on heap)
        }
    }
}
