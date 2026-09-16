using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Models
{
    // A record - reference type, but with built-in VALUE-based equality
    // and a concise syntax for immutable data
    public record PersonRecord(string Name, int Age);
}
