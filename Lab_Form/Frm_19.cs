using System;
using System.CodeDom;
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
    public partial class Frm_19 : Form
    {
        public Frm_19()
        {
            InitializeComponent();
        }

        private void Frm_19_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age_Valid = 0;
            bool Num = int.TryParse(textBox2.Text, out Age_Valid);
            if (Num)
            {
                Employee emp = new Employee(EmployeeName: textBox1.Text, Age_Valid);
                label1.Text = "姓名: " + emp.Name + " , 年齡: " + emp.Age;
            }
            else
            {
                MessageBox.Show("年齡輸入錯誤: " + textBox2.Text);
                textBox2.Clear();
                textBox2.Focus();
            }
        }
    }
}
