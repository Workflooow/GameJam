using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class User
    {
        int cash;
        int worth;
        List<Valuta> possessedCurrencies = new List<Valuta>();

        public void calcWorth()
        {
            worth = 0;
            foreach (var item in possessedCurrencies)
            {
                worth += item.value;
            }
        }
    }
}
