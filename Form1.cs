using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Практичкеская_работа__3
{
    public partial class Form1 : Form
    {
        string[] shopList = { "Яблоко", "Печенье", "Киви", "Шоколадка", "Биг ланч", "Сыр с плесенью", "Петрушка"};
        string[] itemsList = { "Фейри", "Салфетки", "Мыло", "Влажные салфетки", "Туалетная бумага"};
        List<string> purchases = new List<string> { };
        void ClearAll()
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
        void CreateList()
        {
            try
            {
                bool flag = false;
                purchases.Clear();
                for (int i = 0; i < 6; i++)
                {
                    if (string.IsNullOrWhiteSpace(groupBox1.Controls[$"textBox{i + 1}"].Text))
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        purchases.Add(groupBox1.Controls[$"textBox{i + 1}"].Text);
                        groupBox1.Controls[$"textBox{i + 1}"].Enabled = false;
                    }
                }
                else MessageBox.Show("Не все поля заполнены!", "Что-то не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FindMaxKey()
        {
            Dictionary<string, int> max = new Dictionary<string, int>();
            if (purchases.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Что-то не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < purchases.Count; i++)
                {
                    if (max.ContainsKey(groupBox1.Controls[$"textBox{i + 1}"].Text))
                    {
                        max[groupBox1.Controls[$"textBox{i + 1}"].Text] += 1;
                    }
                    else max[groupBox1.Controls[$"textBox{i + 1}"].Text] = 1;
                }
                int maxKVal = max.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                string maxKey = null;

                if (max.Values.Distinct().Count() <= 1)
                {
                    maxKey = "Все элементы равны!";
                }
                else
                {
                    foreach (KeyValuePair<string, int> i in max)
                    {
                        if (i.Value == maxKVal) maxKey += i.Key.ToString() + ", ";
                    }
                    maxKey = maxKey.Substring(0, maxKey.Length - 2);
                }
                textBoxMax.Text = maxKey;
            }
        }
        void FillProductsList()
        {
            purchases.Clear();
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                purchases.Add(shopList[rand.Next(shopList.Length)]);
            }
            for (int i = 0; i < purchases.Count; i++)
            {
                groupBox1.Controls[$"textBox{i + 1}"].Text = purchases[i].ToString();
                groupBox1.Controls[$"textBox{i + 1}"].Enabled = false;
            }
        }
        void FillItemsList()
        {
            purchases.Clear();
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                purchases.Add(itemsList[rand.Next(itemsList.Length)]);
            }
            for (int i = 0; i < purchases.Count; i++)
            {
                groupBox1.Controls[$"textBox{i + 1}"].Text = purchases[i].ToString();
                groupBox1.Controls[$"textBox{i + 1}"].Enabled = false;
            }
        }
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
            FillProductsList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRand.Checked)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                CreateBtn.Enabled = false;
            }
        }

        private void radioButtonHand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHand.Checked)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                CreateBtn.Enabled = true;
            }
        }

        private void textBoxА1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillItemsList();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindMaxKey();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 NewWindow = new Form2();
            NewWindow.Show();
        }
    }
}
