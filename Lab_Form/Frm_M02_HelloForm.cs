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
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string NameEng = txtNameEng.Text;
            string Gender = txtGender.Text;
            string Zodiac = txtZodiac.Text;
            string message = "Hello, 我是 " + Name + ",\n" +
                "英文名字是 " + NameEng + ",\n" +
                "性別是 " + Gender + ",\n" +
                "星座是 " + Zodiac + ",\n" +
                "很高興認識你。";
            MessageBox.Show(message);
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string NameEng = txtNameEng.Text;
            string Gender = txtGender.Text;
            string Zodiac = txtZodiac.Text;
            string message = "Hi, 我是 " + Name + ",\n" +
                "英文名字是 " + NameEng + ",\n" +
                "性別是 " + Gender + ",\n" +
                "星座是 " + Zodiac + ",\n" +
                "很高興認識你。";
            MessageBox.Show(message);
        }
    }
}
