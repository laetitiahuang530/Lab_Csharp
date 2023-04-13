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
    public partial class Frm_M11_ScreenSaver : Form
    {
        int vx = 20;
        int vy = 10;
        public Frm_M11_ScreenSaver()
        {
            InitializeComponent();
        }

        private void Frm_M11_ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left + pictureBox1.Width > this.Width)
            {
                vx = -vx;
            }
            else if (pictureBox1.Top + pictureBox1.Height > this.Height)
            {
                vy = -vy;
            }
            else if (pictureBox1.Top < 0)
            {
                vy = -vy;
            }
            else if (pictureBox1.Left < 0)
            {
                vx = -vx;
            }
            pictureBox1.Left += vx;
            pictureBox1.Top += vy;
        }
    }
}
