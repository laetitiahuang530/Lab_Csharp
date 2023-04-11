using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_21 : Form
    {
        public Frm_21()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void button1_Click(object sender, EventArgs e)
        {
            //if (flag)
            //{
            //    button1.BackColor = Color.Blue;
            //}
            //else
            //{
            //    button1.BackColor = Color.Green;
            //}
            button1.BackColor = flag ? Color.Pink : Color.SkyBlue;
            flag = !flag;
        }

        public string CalcScore(int score)
        {
            if (score < 0 || score > 100) {
               return "請輸入0~100數字";
            }
            else if (score >= 90 && score <= 100) {
                return "A";
            }
            else if (score >= 80 && score <= 89) {
                return "B";
            }
            else if (score >= 70 && score <= 79)
            {
                return "C";
            }
            else if (score >= 60 && score <= 69)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "級數 : " + CalcScore(Int32.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.Pink;
                control.ForeColor = Color.Black;
                control.Left -= 5;
                control.Top -= 5;
            }
        }
    }
}
