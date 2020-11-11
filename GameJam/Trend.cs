using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Trend
    {
        public int TicksRemaining { get; private set; }
        public Currency Currency { get; private set; }

        private double oldMin;
        private double oldMax;

        public Trend(int howManyTicks, Currency currency, double trendWeight)
        {
            if (trendWeight < 0)
            {
                trendWeight = 0.01;
            }

            TicksRemaining = howManyTicks;
            Currency = currency;
            oldMin = currency.MinValue;
            oldMax = currency.MaxValue;

            currency.MinValue *= trendWeight;
            currency.MaxValue *= trendWeight;
        }

        public void nextTick()
        {
            TicksRemaining--;

            if (TicksRemaining == 0)
            {
                Currency.MinValue = oldMin;
                Currency.MaxValue = oldMax;
            }
        }
    }
}
