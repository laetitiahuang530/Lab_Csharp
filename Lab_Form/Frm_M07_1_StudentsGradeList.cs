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
    public partial class Frm_M07_1_StudentsGradeList : Form
    {
        public Frm_M07_1_StudentsGradeList()
        {
            InitializeComponent();
        }
        int Total = 0;
        int Avg = 0;
        List<int> chineseScores = new List<int>();
        List<int> englishScores = new List<int>();
        List<int> mathScores = new List<int>();
        private void btnAddStudentInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtChinese.Text)
                || string.IsNullOrEmpty(txtEnglish.Text) || string.IsNullOrEmpty(txtMath.Text))
            {
                MessageBox.Show("請輸入正確資料!!!");
            }
            else
            {
                Total = Convert.ToInt32(txtChinese.Text) +
                    Convert.ToInt32(txtEnglish.Text) +
                    Convert.ToInt32(txtMath.Text);
                Avg = Total / 3;
                Dictionary<string, int> dict = new Dictionary<string, int>()
                {
                    {"國語", Convert.ToInt32(txtChinese.Text)},
                    {"英文", Convert.ToInt32(txtChinese.Text)},
                    {"數學", Convert.ToInt32(txtChinese.Text)}
                };
                chineseScores.Add(dict["國語"]);
                englishScores.Add(dict["英文"]);
                mathScores.Add(dict["數學"]);
                //----->Max
                var maxValueKey = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                var maxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
                //----->Max
                //----->Min
                var minValueKey = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                var minValue = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
                //----->Min

                string[] row = {txtName.Text, txtChinese.Text,  txtEnglish.Text, txtMath.Text,
                    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue};
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            btnRemoveStudentInfo.Enabled = true;
        }
    }
}
