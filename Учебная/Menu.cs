using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Two;
using One;
using Three;
using Four;
using Five;

namespace Учебная
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            One.One form1 = new One.One();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Two.Two form2 = new Two.Two();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Three.Three form3 = new Three.Three();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Four.Four form4 = new Four.Four();
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Five.Five form5 = new Five.Five();
            form5.ShowDialog();
        }
    }
}
