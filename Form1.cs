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
        string[] shopList = { "яблоко", "масло", "молоко", "печенье", "куриная грудка", "замороженные овощи", "киви", "шоколадка", "биг ланч" };
        string[] itemsList = { "Фейри", "Салфетки", "Мыло", "Влажные салфетки", "Туалетная бумага"};
        List<string> purchases = new List<string> { };
        public Form1()
        {
            InitializeComponent();
            radioButtonRand.Checked = true;
            radioButtonHand.Checked = false;
            
        }

        private void radioBtnRandTrue_CheckedChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                purchases.Add(shopList[rand.Next(shopList.Length)]);
                //temp += purchases[i] + " ";
            }
            for (int i = 0; i < purchases.Count; i++)
            {
                groupBox1.Controls[$"textBox{i + 1}"].Text = purchases[i].ToString();
                groupBox1.Controls[$"textBox{i + 1}"].Enabled = false;
            }
            //for (int i = 0; i < purchases.Count; i++)
            //{
            //    groupBoxListA.Controls[$"textBoxA{i + 1}"].Text = "123";
            //    /*groupBoxListA.Controls[$"textBoxА{i + 1}"].Text = "tew";*///purchases[i].ToString();
            //    groupBoxListA.Controls[$"textBoxА{i + 1}"].Enabled = true;
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRand.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void radioButtonHand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHand.Checked)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void textBoxА1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Enabled = true;
            textBox2.Clear();
            textBox2.Enabled = true;
            textBox3.Clear();
            textBox3.Enabled = true;
            textBox4.Clear();
            textBox4.Enabled = true;
            textBox5.Clear();
            textBox5.Enabled = true;
            textBox6.Clear();
            textBox6.Enabled = true;
            textBoxMax.Clear();
            purchases.Clear();
        }
    }
}
