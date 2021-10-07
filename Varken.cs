using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    internal class Varken : Dier
    {
        public SoundPlayer VarkensoundPlayer;
        public Varken(int gewicht) : base(gewicht)
        {
        }
        public string Oeink()
        {
            VarkensoundPlayer = new SoundPlayer("grouinement.wav");
            VarkensoundPlayer.Play();
            return base.Zegt("groink");
        }

        public override string? ToString()
        {
            return Oeink();
        }
    }
}
