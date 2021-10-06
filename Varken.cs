using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Varken : Dier
    {
        public Varken(int gewicht) : base(gewicht)
        {
        }
        public string Oeink()
        {
            return base.Zegt("groink");
        }

        public override string? ToString()
        {
            return Oeink() + " Dat is een varken " + "zijn gewicht is " + gewicht;
        }
    }
}
