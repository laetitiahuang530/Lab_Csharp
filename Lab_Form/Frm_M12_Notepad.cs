using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M12_Notepad : Form
    {
        public Frm_M12_Notepad()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            string timeString = currenTime.ToString("tt h:mm:ss");
            toolTime.Text = timeString;
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "此版本為張佑晨在資策會C#記事本作業1.0版,\n敬請您安心服用",
                "關於");
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "此版本為張佑晨在資策會C#記事本作業1.0版,\n敬請您安心服用",
                "關於");
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "開始";
            openFileDialog.FileName = "openFileDialog1";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "開始";
            openFileDialog.FileName = "openFileDialog1";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = textBox1.Text.ToLower();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.WordWrap)
            {
                textBox1 .WordWrap = false;
            }
            else
            {
                textBox1.WordWrap = true;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
    }
}
