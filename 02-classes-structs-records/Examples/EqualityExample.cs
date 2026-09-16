using _02_classes_structs_records.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Examples
{
    public static class EqualityExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Class equality: reference-based by default ---");
            var class1 = new PersonClass { Name = "John", Age = 30 };
            var class2 = new PersonClass { Name = "John", Age = 30 };
            Console.WriteLine($"class1 == class2: {class1 == class2}"); // false - different objects

            Console.WriteLine();
            Console.WriteLine("--- Record equality: value-based automatically ---");
            var record1 = new PersonRecord("John", 30);
            var record2 = new PersonRecord("John", 30);
            Console.WriteLine($"record1 == record2: {record1 == record2}"); // true - same values

            Console.WriteLine();
            Console.WriteLine("--- Record struct equality: also value-based ---");
            var recordStruct1 = new PersonRecordStruct("John", 30);
            var recordStruct2 = new PersonRecordStruct("John", 30);
            Console.WriteLine($"recordStruct1 == recordStruct2: {recordStruct1 == recordStruct2}"); // true
        }
    }
}
