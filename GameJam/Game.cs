using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Game
    {
        public List<Currency> allCurrencies = new List<Currency>();
        public List<Trend> allTrends = new List<Trend>();
        List<List<Currency>> historicalValues = new List<List<Currency>>();
        public int min = 10;
        public int max = 100;
        static Random r = new Random();

        public Dictionary<Currency, int> ownedMetals;
        public double money = 150;

        public Game()
        {
            allCurrencies.Add(new Currency("a", 0.1, 1));
            allCurrencies.Add(new Currency("b", 0.1, 1));
            allTrends.Add(new Trend(r.Next(1, 10), allCurrencies[0], nextDouble(0, 1)));
            allTrends.Add(new Trend(r.Next(1, 10), allCurrencies[1], nextDouble(0, 1)));
            ownedMetals.Add(allCurrencies[0], 0);
            ownedMetals.Add(allCurrencies[1], 0);
        }

        public void advanceTimeStep()
        {
            for (int i = 0; i < allTrends.Count-1; i++)
            {
                allTrends[i].nextTick();
                if (allTrends[i].tickDone())
                {
                    allTrends[i] = new Trend(r.Next(1, 10), allTrends[i].Currency, nextDouble(0, 2.01));
                }
            }

            List<Currency> hValues = new List<Currency>();
            foreach (var item in allCurrencies)
            {
                hValues.Add(new Currency(item.Name,
                                         item.Value,
                                         item.MinValue,
                                         item.MaxValue));
                item.newRandomValue();
            }
            historicalValues.Add(hValues);
        }

        public static double nextDouble(double min, double max)
        {
            double random = r.NextDouble();
            return min + random * (max - min);
        }

        public void buy(Currency cBuy, int amount)
        {
            money -= cBuy.Value * amount;
            ownedMetals[cBuy] += amount;
        }

        public void sell(Currency cSell, int amount)
        {
            money += cSell.Value * amount;
            ownedMetals[cSell] += amount;
        }


    }
}
