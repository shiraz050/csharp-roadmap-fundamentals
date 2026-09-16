using _02_classes_structs_records.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Examples
{
    public static class MutabilityExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Class: mutable, shared reference ---");
            var personClass = new PersonClass { Name = "John", Age = 30 };
            Mutate(personClass);
            Console.WriteLine($"personClass.Name = {personClass.Name}"); // "Jane" - changed!

            Console.WriteLine();
            Console.WriteLine("--- Struct: copied, original untouched ---");
            var personStruct = new PersonStruct { Name = "John", Age = 30 };
            Mutate(personStruct);
            Console.WriteLine($"personStruct.Name = {personStruct.Name}"); // still "John"

            Console.WriteLine();
            Console.WriteLine("--- Record: 'immutable' via 'with' expression ---");
            var personRecord = new PersonRecord("John", 30);
            var updatedRecord = personRecord with { Name = "Jane" }; // creates a NEW record
            Console.WriteLine($"original: {personRecord.Name}, updated: {updatedRecord.Name}");
        }

        private static void Mutate(PersonClass person) => person.Name = "Jane";
        private static void Mutate(PersonStruct person) => person.Name = "Jane"; // only changes the copy
    }
}
