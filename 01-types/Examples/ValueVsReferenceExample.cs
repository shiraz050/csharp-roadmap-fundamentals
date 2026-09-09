using _01_types.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_types.Examples
{
    public static class ValueVsReferenceExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Value Type Example ---");
            int number = 10;
            ChangeValue(number);
            Console.WriteLine($"After ChangeValue: {number}"); // still 10

            Console.WriteLine();
            Console.WriteLine("--- Reference Type Example ---");
            Person person = new Person { Name = "John" };
            ChangePerson(person);
            Console.WriteLine($"After ChangePerson: {person.Name}"); // changed to "Jane"

            Console.WriteLine();
            Console.WriteLine("--- Struct is a Value Type ---");
            PointStruct p1 = new PointStruct { X = 1, Y = 2 };
            PointStruct p2 = p1; // copies the struct
            p2.X = 99;
            Console.WriteLine($"p1.X = {p1.X}, p2.X = {p2.X}"); // p1 unaffected
        }

        private static void ChangeValue(int value)
        {
            value = 20; // only changes the local copy
        }

        private static void ChangePerson(Person person)
        {
            person.Name = "Jane"; // changes the actual object via the reference
        }
    }
}
