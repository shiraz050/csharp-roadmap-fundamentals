using System;
using System.Collections.Generic;
using System.Text;

namespace _01_types.Examples
{
    public static class BoxingExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Boxing / Unboxing Example ---");
            int original = 42;
            object boxed = original;   // Boxing: value type -> heap-allocated object
            int unboxed = (int)boxed;  // Unboxing: object -> value type
            Console.WriteLine($"Original: {original}, Boxed: {boxed}, Unboxed: {unboxed}");
        }
    }
}
