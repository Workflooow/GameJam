using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Currency
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        private double _minValue;
        private double _maxValue;

        public double MinValue {
            get => _minValue;
            set
            {
                if (value < hardMinValue)
                {
                    _minValue = hardMinValue;
                }
                else if (value > hardMaxValue)
                {
                    _minValue = hardMaxValue;
                }
                else
                {
                    _minValue = value;
                }
            }
        }
        public double MaxValue {
            get => _maxValue;
            set
            {
                if (value > hardMaxValue)
                {
                    _maxValue = hardMaxValue;
                }
                else if (value < hardMinValue)
                {
                    _maxValue = hardMinValue;
                }
                else
                {
                    _maxValue = value;
                }
            }
        }

        private double hardMinValue;
        private double hardMaxValue;

        public Currency(string name, double minValue, double maxValue, double hardMinValue, double hardMaxValue)
            : this(name, Convert.ToInt32(Game.nextDouble(minValue, maxValue)), minValue, maxValue, hardMinValue, hardMaxValue)
        {
        }

        public Currency(string name, int value, double minValue, double maxValue, double hardMinValue, double hardMaxValue)
        {
            Name = name;
            Value = value;
            this.hardMinValue = hardMinValue;
            this.hardMaxValue = hardMaxValue;

            MinValue = minValue;
            MaxValue = maxValue;
        }

        public void newRandomValue()
        {
            this.Value = Convert.ToInt32(Game.nextDouble(MinValue, MaxValue));
        }
    }
}
