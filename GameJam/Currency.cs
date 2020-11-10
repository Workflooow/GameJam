using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Currency
    {
        public string Name { get; private set; }
        public double Value { get; private set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public Currency(string name, double minValue, double maxValue)
            : this(name, nextDouble(minValue, maxValue), minValue, maxValue)
        {
        }

        public Currency(string name, double value, double minValue, double maxValue)
        {
            Name = name;
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public void newRandomValue()
        {
            this.Value = nextDouble(MinValue, MaxValue);
        }

        public Currency asOther(Currency other)
        {
            return new Currency(other.Name, Value / other.Value, MinValue, MaxValue);
        }

        private static double nextDouble(double min, double max)
        {
            double random = new Random().NextDouble();
            return min + random * (max - min);
        }
    }
}
