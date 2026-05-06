using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практичкеская_работа__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioBtnRandTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRandTrue.Checked == true) radioBtnRandTrue.Checked = false;
            else radioBtnRandTrue.Checked = true;
        }

        private void textBoxА5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxА4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxRandom_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
