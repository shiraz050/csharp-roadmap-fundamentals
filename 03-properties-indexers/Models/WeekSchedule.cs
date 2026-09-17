using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Models
{
    public class WeekSchedule
    {
        private readonly string[] _days = new string[7];

        // Indexer - lets callers use schedule[0] instead of a method call
        public string this[int dayIndex]
        {
            get => _days[dayIndex];
            set => _days[dayIndex] = value;
        }
    }
}
