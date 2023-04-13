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
    public partial class Frm_M10_XOGame : Form
    {
        public Frm_M10_XOGame()
        {
            InitializeComponent();
        }
        bool Switch = true;
        bool done = false;
        int count = 0;
        private void finishGame()
        {
            if (button1.Text != string.Empty &&
                button2.Text != string.Empty &&
                button3.Text != string.Empty &&
                button1.Text == button2.Text && 
                button2.Text == button3.Text)
            {
                MessageBox.Show(button1.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button4.Text != string.Empty &&
                button5.Text != string.Empty &&
                button6.Text != string.Empty && 
                button4.Text == button5.Text && 
                button5.Text == button6.Text)
            {
                MessageBox.Show(button4.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button7.Text != string.Empty &&
                button8.Text != string.Empty &&
                button9.Text != string.Empty &&
                button7.Text == button8.Text &&
                button8.Text == button9.Text)
            {
                MessageBox.Show(button7.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button1.Text != string.Empty &&
                button4.Text != string.Empty &&
                button7.Text != string.Empty &&
                button1.Text == button4.Text &&
                button4.Text == button7.Text)
            {
                MessageBox.Show(button1.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button2.Text != string.Empty &&
                button5.Text != string.Empty &&
                button8.Text != string.Empty &&
                button2.Text == button5.Text &&
                button5.Text == button8.Text)
            {
                MessageBox.Show(button2.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button3.Text != string.Empty &&
                button6.Text != string.Empty &&
                button9.Text != string.Empty &&
                button3.Text == button6.Text &&
                button6.Text == button9.Text)
            {
                MessageBox.Show(button3.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button1.Text != string.Empty &&
                button5.Text != string.Empty &&
                button9.Text != string.Empty &&
                button1.Text == button5.Text &&
                button5.Text == button9.Text)
            {
                MessageBox.Show(button1.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (button3.Text != string.Empty &&
                button5.Text != string.Empty &&
                button7.Text != string.Empty &&
                button3.Text == button5.Text &&
                button5.Text == button7.Text)
            {
                MessageBox.Show(button5.Text + " 手獲勝!", "完局!");
                done = true;
            }
            if (count == 9 && !done)
            {
                MessageBox.Show("合局", "完局!");
                done = true;
            }
        }
        private void refresh()
        {
            if (done)
            {
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button3.Text = string.Empty;
                button4.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button7.Text = string.Empty;
                button8.Text = string.Empty;
                button9.Text = string.Empty;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                done = false;
                count = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Switch) {
                button1.Text = "X";
                Switch = false;
            } else
            {
                button1.Text = "O";
                Switch = true;
            }
            count++;
            button1.Enabled = false;
            finishGame();
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button2.Text = "X";
                Switch = false;
            }
            else
            {
                button2.Text = "O";
                Switch = true;
            }
            count++;
            button2.Enabled = false;
            finishGame();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button3.Text = "X";
                Switch = false;
            }
            else
            {
                button3.Text = "O";
                Switch = true;
            }
            count++;
            button3.Enabled = false;
            finishGame();
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button4.Text = "X";
                Switch = false;
            }
            else
            {
                button4.Text = "O";
                Switch = true;
            }
            count++;
            button4.Enabled = false;
            finishGame();
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button5.Text = "X";
                Switch = false;
            }
            else
            {
                button5.Text = "O";
                Switch = true;
            }
            count++;
            button5.Enabled = false;
            finishGame();
            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button6.Text = "X";
                Switch = false;
            }
            else
            {
                button6.Text = "O";
                Switch = true;
            }
            count++;
            button6.Enabled = false;
            finishGame();
            refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button7.Text = "X";
                Switch = false;
            }
            else
            {
                button7.Text = "O";
                Switch = true;
            }
            count++;
            button7.Enabled = false;
            finishGame();
            refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button8.Text = "X";
                Switch = false;
            }
            else
            {
                button8.Text = "O";
                Switch = true;
            }
            count++;
            button8.Enabled = false;
            finishGame();
            refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Switch)
            {
                button9.Text = "X";
                Switch = false;
            }
            else
            {
                button9.Text = "O";
                Switch = true;
            }
            count++;
            button9.Enabled = false;
            finishGame();
            refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            done = true;
            refresh();
        }
    }
}
