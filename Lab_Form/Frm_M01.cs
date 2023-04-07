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
    public partial class Frm_M01 : Form
    {
        public Frm_M01()
        {
            InitializeComponent();
        }
        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M02_HelloForm frm_hello = new Frm_M02_HelloForm();
            frm_hello.TopLevel = false;
            frm_hello.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_hello);
            frm_hello.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M03_LoanForm frm_loan = new Frm_M03_LoanForm();
            frm_loan.TopLevel = false;
            frm_loan.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_loan);
            frm_loan.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M05_POSForm frm_POS = new Frm_M05_POSForm();
            frm_POS.TopLevel = false;
            frm_POS.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_POS);
            frm_POS.Show();
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M06_StudentStructForm frm_StudentStruct = new Frm_M06_StudentStructForm();
            frm_StudentStruct.TopLevel = false;
            frm_StudentStruct.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_StudentStruct);
            frm_StudentStruct.Show();
        }

        private void btnStudentsGrade_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M07_StudentsGrade frm_StudentsGrade = new Frm_M07_StudentsGrade();
            frm_StudentsGrade.TopLevel = false;
            frm_StudentsGrade.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_StudentsGrade);
            frm_StudentsGrade.Show();
        }

        private void btnStudentsGradeList_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method03();
            mc.Method08();

        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "John";
            mem1.Age = 30;

            //string mem1Name = mem1.Name;
            MessageBox.Show(mem1.Name + "," + mem1.Age);

            Member mem2 = new Member
            {
                Name = "Wick",
                Age = 32
            };
            MessageBox.Show(mem2.Name + "," + mem2.Age);
        }

        private void Frm_M01_Load(object sender, EventArgs e)
        {
            //sform1 = this;//->2. 
        }
    }
}
