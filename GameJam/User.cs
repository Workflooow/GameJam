using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class User
    {
        List<Currency> possessedCurrencies = new List<Currency>();
        public User()
        {

        }

        public double getWorthAs(Currency asCurrency)
        {
            double worth = 0;
            foreach (var currency in possessedCurrencies)
            {
                worth += currency.asOther(asCurrency).Value;
            }

            return worth;
        }
    }
}
