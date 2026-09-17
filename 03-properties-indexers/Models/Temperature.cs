using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Models
{
    public class Temperature
    {
        private double _celsius;

        public double Celsius
        {
            get => _celsius;
            set
            {
                if (value < -273.15)
                    throw new ArgumentOutOfRangeException(nameof(value), "Below absolute zero.");
                _celsius = value;
            }
        }

        // Computed property - no backing field, calculated on access
        public double Fahrenheit => (_celsius * 9 / 5) + 32;
    }
}
