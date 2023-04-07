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
    public partial class Frm_23 : Form
    {
        public Frm_23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            MessageBox.Show($"{a}, {b}");
            Swap<int>(ref a, ref b);
            MessageBox.Show($"{a}, {b}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = "aaaa";
            string b = "bbbb";
            MessageBox.Show($"{a}, {b}");
            Swap<string>(ref a, ref b);
            MessageBox.Show($"{a}, {b}");
        }
        void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        void Swap(ref string a, ref string b)
        {
            string c = a;
            a = b;
            b = c;
        }
        void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}
