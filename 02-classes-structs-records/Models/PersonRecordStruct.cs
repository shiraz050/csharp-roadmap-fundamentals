using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Models
{
    // A record struct - value type (like struct) but with
    // value-based equality (like record)
    public record struct PersonRecordStruct(string Name, int Age);
}
