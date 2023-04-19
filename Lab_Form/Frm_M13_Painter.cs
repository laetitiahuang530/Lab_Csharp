using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class Frm_M13_Painter : Form
    {
        public Frm_M13_Painter()
        {
            InitializeComponent();
        }
        int x0, y0;
        Pen myPen = new Pen(Color.Black, 1);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(myPen, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog.Color;
                myPen.Color = colorDialog.Color;
            }
        }

        private void Frm_M13_Painter_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            myPen.Width = trackBar1.Value;
        }
    }
}
