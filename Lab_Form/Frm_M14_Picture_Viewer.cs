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
    public partial class Frm_M14_Picture_Viewer : Form
    {
        public Frm_M14_Picture_Viewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_PicView frm_PicView = new Frm_PicView();
            frm_PicView.pictureBox1.Image = pictureBox1.Image;
            frm_PicView.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_PicView frm_PicView = new Frm_PicView();
            frm_PicView.pictureBox1.Image = pictureBox2.Image;
            frm_PicView.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_PicView frm_PicView = new Frm_PicView();
            frm_PicView.pictureBox1.Image = pictureBox3.Image;
            frm_PicView.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_PicView frm_PicView = new Frm_PicView();
            frm_PicView.pictureBox1.Image = pictureBox4.Image;
            frm_PicView.Show();
        }
    }
}
