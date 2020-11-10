using System;
using System.Collections.Generic;
using System.Text;

namespace GameJam
{
    class Valuta
    {
        public int value;
        public string name;

        public Valuta(string n)
        {
            name = n;
            Random r = new Random();
            value = r.Next(0, 10);
        }

        public void fluctuate()
        {
            if (value == 0)
            {

            }
        }
    }
}
