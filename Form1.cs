using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Dieren;

namespace Dieren2
{
    public partial class Form1 : Form
    {

        public SoundPlayer KoesoundPlayer;
        public SoundPlayer SlangsoundPlayer;
        public SoundPlayer VarkensoundPlayer;
        public Form1()
        {
            InitializeComponent();
            KoesoundPlayer = new SoundPlayer("meuglement.wav");
            SlangsoundPlayer = new SoundPlayer("SIFFLEMENT.wav");
            VarkensoundPlayer = new SoundPlayer("grouinement.wav");
        }

        private void btHoren_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe(1000);
            Dier varken= new Varken(250);
            Dier slang = new Slang(5);

            if(cbKoe.Checked)
            {
                MessageBox.Show(koe.ToString());
                KoesoundPlayer.Play();
            }
            if (cbSlang.Checked)
            {
                MessageBox.Show(slang.ToString());
                SlangsoundPlayer.Play();
            }
            
            if(cbVarken.Checked)
            {
                MessageBox.Show(varken.ToString());
                VarkensoundPlayer.Play();
            }
        }
    }
}
