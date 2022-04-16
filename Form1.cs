using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_Generator
{
    public partial class Form1 : Form
    {
        int dis = 0,cnt=0;
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p=0;
            cnt++;
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox2.Items.Add(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
                p = 50000;
            else if (comboBox1.SelectedIndex == 1)
                p = 40000;
            else if (comboBox1.SelectedIndex == 2)
                p = 20000;
            else if (comboBox1.SelectedIndex == 3)
                p = 40000;
            else if (comboBox1.SelectedIndex == 4)
                p = 10000;
            else if (comboBox1.SelectedIndex == 5)
                p = 100000;
            listBox3.Items.Add(p*Convert.ToInt32(textBox1.Text));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            while (listBox3.SelectedIndex < cnt)
            {
                total += Convert.ToInt32(listBox3.SelectedItem);
                if (listBox3.SelectedIndex != cnt - 1)
                    listBox3.SelectedIndex++;
                else
                    break;
            }
            dis = (Convert.ToInt32(textBox2.Text)) * total;
            dis = dis / 100;
            label9.Text = (total - dis).ToString();
            label6.Text = total.ToString();
            label15.Text = dis.ToString();
            label12.Text = "";
            label13.Text = "";
            while (listBox3.SelectedIndex < cnt)
            {
                label12.Text += listBox1.SelectedItem + "\n";
                if (listBox1.SelectedIndex != cnt - 1)
                    listBox1.SelectedIndex++;
                else
                    break;
            }

            listBox3.SelectedIndex = 0;
            while (listBox3.SelectedIndex < cnt)
            {
                label13.Text += "\n" + listBox3.SelectedItem;
                if (listBox3.SelectedIndex != cnt - 1)
                    listBox3.SelectedIndex++;
                else
                    break;
            }
        }
    }
}
