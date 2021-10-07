using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Slang : Dier
    {
        public SoundPlayer SlangsoundPlayer;
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public string ssst()
        {
            SlangsoundPlayer = new SoundPlayer(@"C:\Users\ahmad\source\repos\Dieren2\bin\Debug\net6.0-windows\SIFFLEMENT.wav");
            SlangsoundPlayer.Play();
            return base.Zegt("ssj");
        }

        public override string? ToString()
        {
            return ssst();
        }
    }
}
