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
            splitContainer2.Panel2.Controls.Clear();
            Frm_M07_1_StudentsGradeList frm_studentGradeList = new Frm_M07_1_StudentsGradeList();
            frm_studentGradeList.TopLevel = false;
            frm_studentGradeList.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_studentGradeList);
            frm_studentGradeList.Show();

        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M08_Method frm_method = new Frm_M08_Method();
            frm_method.TopLevel = false;
            frm_method.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_method);
            frm_method.Show();
        }

        private void btnMyCalc_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M09_MyCalc frm_method = new Frm_M09_MyCalc();
            frm_method.TopLevel = false;
            frm_method.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_method);
            frm_method.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M08_Method frm_ForDoWhile = new Frm_M08_Method();
            frm_ForDoWhile.TopLevel = false;
            frm_ForDoWhile.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_ForDoWhile);
            frm_ForDoWhile.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M10_XOGame frm_XOGame = new Frm_M10_XOGame();
            frm_XOGame.TopLevel = false;
            frm_XOGame.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_XOGame);
            frm_XOGame.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Frm_M11_ScreenSaver frm_ScreenSaver = new Frm_M11_ScreenSaver();
            frm_ScreenSaver.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M12_Notepad frm_Notepad = new Frm_M12_Notepad();
            frm_Notepad.TopLevel = false;
            frm_Notepad.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_Notepad);
            frm_Notepad.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M13_Painter frm_Painter = new Frm_M13_Painter();
            frm_Painter.TopLevel = false;
            frm_Painter.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_Painter);
            frm_Painter.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm_M14_Picture_Viewer frm_PicViewer = new Frm_M14_Picture_Viewer();
            frm_PicViewer.TopLevel = false;
            frm_PicViewer.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(frm_PicViewer);
            frm_PicViewer.Show();
        }
    }
}
