using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            One form1 = new One();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Two form2 = new Two();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Three form3 = new Three();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Four form4 = new Four();
            form4.ShowDialog();
        }
    }
}
