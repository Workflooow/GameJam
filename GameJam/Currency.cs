using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Currency
    {
        public string Name { get; private set; }
        public double Value { get; private set; }

        private double minValue;
        private double maxValue;

        public double MinValue {
            get => minValue;
            set
            {
                if (value < hardMinValue)
                {
                    minValue = hardMinValue;
                }
                else if (value > hardMaxValue)
                {
                    minValue = hardMaxValue;
                }
                else
                {
                    minValue = value;
                }
            }
        }
        public double MaxValue {
            get => maxValue;
            set
            {
                if (value > hardMaxValue)
                {
                    maxValue = hardMaxValue;
                }
                else if (value < minValue)
                {
                    maxValue = hardMinValue;
                }
                else
                {
                    maxValue = value;
                }
            }
        }

        private double hardMinValue;
        private double hardMaxValue;

        public Currency(string name, double minValue, double maxValue, double hardMinValue, double hardMaxValue)
            : this(name, Game.nextDouble(minValue, maxValue), minValue, maxValue, hardMinValue, hardMaxValue)
        {
        }

        public Currency(string name, double value, double minValue, double maxValue, double hardMinValue, double hardMaxValue)
        {
            Name = name;
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
            this.hardMinValue = hardMinValue;
            this.hardMaxValue = hardMaxValue;
        }

        public void newRandomValue()
        {
            this.Value = Game.nextDouble(MinValue, MaxValue);
        }

        public Currency asOther(Currency other)
        {
            return new Currency(Name, Value / other.Value, MinValue, MaxValue, hardMinValue, hardMaxValue);
        }
    }
}
