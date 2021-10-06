using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Koe : Dier
    {
        

        public Koe(int gewicht) : base(gewicht)
        {
        }

        public  string boet()
        {
            return base.Zegt("boe");
        }

        public override string? ToString()
        {
            return boet()  + " Dat is een koe "+ "zijn gewicht is " + gewicht;
        }

        
    }
}
