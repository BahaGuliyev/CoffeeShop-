using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseClick += mouseclick;
            pictureBox2.MouseClick += mouseclick;
            pictureBox3.MouseClick += mouseclick;
            pictureBox4.MouseClick += mouseclick;
            pictureBox5.MouseClick += mouseclick;
            pictureBox6.MouseClick += mouseclick;
            pictureBox7.MouseClick += mouseclick;
            pictureBox8.MouseClick += mouseclick;
            pictureBox9.MouseClick += mouseclick;
            pictureBox10.MouseClick += mouseclick;
            pictureBox11.MouseClick += mouseclick;
            pictureBox12.MouseClick += mouseclick;
            pictureBox13.MouseClick += mouseclick;
            pictureBox14.MouseClick += mouseclick;
            pictureBox15.MouseClick += mouseclick;
            pictureBox16.MouseClick += mouseclick;
            pictureBox17.MouseClick += mouseclick;
            pictureBox18.MouseClick += mouseclick;

        }
        double total;
        double price;
        string name;
        int qty;
        double sum = 0;

        private void mouseclick(object sender, MouseEventArgs e)
        {
            
            var clickpic = (PictureBox)sender;
            if (clickpic == pictureBox1)    
            {
                name = "Cappuccino";
                price = 3.20;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                textBox1.Text = numericUpDown1.DecimalPlaces.ToString();
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox2)
            {
                name = "Expresso";
                price = 2.80;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox3)
            {
                name = "Americano";
                price = 2.60;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox4)
            {
                name = "Machiato";
                price = 3.70;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox5)
            {
                name = "Mocha";
                price = 4.50;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox6)
            {
                name = "Breve";
                price = 4.30;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox7)
            {
                name = "Hot Chocolate";
                price = 4.50;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox8)
            {
                name = "Tea with Lemon";
                price = 1.20;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox9)
            {
                name = "Green Tea";
                price = 2.00;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox10)
            {
                name = "Daisy Tea";
                price = 1.80;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox11)
            {
                name = "Waffles";
                price = 3.50;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox12)
            {
                name = "Brownies";
                price = 2.70;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox13)
            {
                name = "Cheesecake";
                price = 3.10;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox14)
            {
                name = "Donut";
                price = 1.90;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox15)
            {
                name = "Pancakes";
                price = 4.70;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox16)
            {
                name = "Croissant";
                price = 1.30;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox17)
            {
                name = "Cookies";
                price = 2.50;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }
            else if (clickpic == pictureBox18)
            {
                name = "Brezel";
                price = 0.80;
                qty = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                numericUpDown1.Value = 1;
            }

            total = price * qty;
            this.dataGridView1.Rows.Add(name, price, qty, total);
            sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            sum = sum + Convert.ToDouble(dataGridView1.Rows[row].Cells[3].Value);
            textBox1.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            sum = 0;
            textBox1.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dataGridView1.SelectedRows.Count; row++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[row]);
            }
            sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
                sum = sum + Convert.ToDouble(dataGridView1.Rows[row].Cells[3].Value);
            textBox1.Text = sum.ToString();
        }
    }
}
