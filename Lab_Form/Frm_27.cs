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
    public partial class Frm_27 : Form
    {
        public Frm_27()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\C#\Csharp\暗流.txt", FileMode.OpenOrCreate);
            StreamWriter strWrite = new StreamWriter(fs, Encoding.Default);
            strWrite.Write(txtReadWrite.Text);
            strWrite.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader("C:\\Users\\User\\Desktop\\C#\\Csharp\\安平之光.txt", Encoding.UTF8);
            txtReadWrite.Text = strRead.ReadToEnd();
            strRead.Close();
        }
    }
}
