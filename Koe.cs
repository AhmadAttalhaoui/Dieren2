using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Koe : Dier
    {
        public SoundPlayer KoesoundPlayer;

        public Koe(int gewicht) : base(gewicht)
        {
        }

        public  string boet()
        {
            KoesoundPlayer = new SoundPlayer(@"C:\Users\ahmad\source\repos\Dieren2\bin\Debug\net6.0-windows\meuglement.wav");
            KoesoundPlayer.Play();
            return base.Zegt("boet");
        }

        public override string? ToString()
        {
            return boet();
        }

        
    }
}
