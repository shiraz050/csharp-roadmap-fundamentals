using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Models
{
    // A plain class - reference type, mutable by default
    public class PersonClass
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
