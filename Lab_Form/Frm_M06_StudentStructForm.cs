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
    public partial class Frm_M06_StudentStructForm : Form
    {
        public Frm_M06_StudentStructForm()
        {
            InitializeComponent();
        }
        public string result;
        public string output;
        public string name;
        public int max;
        public int min;
        public int chinese;
        public int english;
        public int math;
        private void btnSave_Click(object sender, EventArgs e)
        {
            name =  txtName.Text;
            chinese = Int32.Parse(txtChinese.Text);
            english = Int32.Parse(txtEnglish.Text);
            math = Int32.Parse(txtMath.Text);
            max = Math.Max(chinese, Math.Max(english, math));
            min = Math.Min(chinese, Math.Min(english, math));
            result = "姓名 : " + name + "\r\n國文 : " + chinese.ToString() +
                "\r\n英文 : " + english.ToString() + "\r\n數學 : " + math.ToString();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtReport.Text = result;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (max == chinese)
            {
                output = "最高科目成績為: 中文" + chinese + "分";
            }
            else if (max == english)
            {
                output = "最高科目成績為: 英文" + english + "分";
            }
            else if (max == math)
            {
                output = "最高科目成績為: 數學" + math + "分";
            }
            if (min == chinese)
            {
                output += "\r\n最低科目成績為: 中文" + chinese + "分";
            }
            else if (min == english)
            {
                output += "\r\n最低科目成績為: 英文" + english + "分";
            }
            else if (min == math)
            {
                output += "\r\n最低科目成績為: 數學" + math + "分";
            }
            txtMaxMin.Text = output;
        }
    }
}
