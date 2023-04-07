using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class Frm_M07_MyCalc : Form
    {
        public Frm_M07_MyCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool isNum1 = double.TryParse(textBox1.Text, out num1);
            bool isNum2 = double.TryParse(textBox2.Text, out num2);
            if (isNum1 && isNum2 ) {
                textBox3.Text = Convert.ToString(num1 + num2);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool isNum1 = double.TryParse(textBox1.Text, out num1);
            bool isNum2 = double.TryParse(textBox2.Text, out num2);
            if (isNum1 && isNum2)
            {
                textBox3.Text = Convert.ToString(num1 - num2);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool isNum1 = double.TryParse(textBox1.Text, out num1);
            bool isNum2 = double.TryParse(textBox2.Text, out num2);
            if (isNum1 && isNum2)
            {
                textBox3.Text = Convert.ToString(num1 * num2);
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool isNum1 = double.TryParse(textBox1.Text, out num1);
            bool isNum2 = double.TryParse(textBox2.Text, out num2);
            if (num2 == 0) { MessageBox.Show("除數不得為零。"); }
            else
            {
                if (isNum1 && isNum2)
                {
                    textBox3.Text = Convert.ToString(num1 / num2);
                }
                else
                {
                    MessageBox.Show("請輸入數值。");
                }
            }
        }
    }
}
