using System;
using System.Collections.Generic;
using System.Text;

namespace _02_classes_structs_records.Models
{
    // A plain struct - value type, copied on assignment/pass
    public struct PersonStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
