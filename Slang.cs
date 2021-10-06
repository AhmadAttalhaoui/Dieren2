using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Slang : Dier
    {
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public string ssst()
        {
            return base.Zegt("ssj");
        }

        public override string? ToString()
        {
            return ssst() + " Dat is een slang pas op!!! " + "zijn gewicht is " + gewicht;
        }
    }
}
