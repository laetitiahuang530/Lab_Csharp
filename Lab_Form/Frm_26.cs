using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_26 : Form
    {
        public Frm_26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append("聽說Lucy常常做運動");
            s.Append(" , 身體健康精神號。");
            textBox1.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = "C:\\Users\\User\\Desktop\\C#\\Csharp\\Lab_Csharp\\Lab_Csharp.sln";
            string result;
            result = Path.GetFullPath(dir) + "\r\n" +
                Path.GetFileName(dir) + "\r\n" +
                Path.GetExtension(dir) + "\r\n" +
                Path.GetDirectoryName(dir) + "\r\n" +
                Path.GetFileNameWithoutExtension(dir);
            textBox1.Text = result;
        }

        private void btnRegex_Click(object sender, EventArgs e)
        {
            bool boolStg = IsStrongPassword(txtPassword.Text);
        }
        bool IsStrongPassword(string password)
        {
            bool result = Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z]).{8,16}");
            return result;
        }
        bool IsIDRight(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }
    }
}
