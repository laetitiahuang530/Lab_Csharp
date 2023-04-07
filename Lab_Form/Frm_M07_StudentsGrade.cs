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
    public partial class Frm_M07_StudentsGrade : Form
    {
        int Total = 0;
        int Avg = 0;
        string minSubject = string.Empty;
        string maxSubject = string.Empty;
        int IDNumber = 1;
        public Frm_M07_StudentsGrade()
        {
            InitializeComponent();
            ValueInit();
        }

        private void ValueInit()
        {
            txtName.Text = "0";
            txtChinese.Text = "0";
            txtEnglish.Text = "0";
            txtMath.Text = "0";
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
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
                IDNumber += 1;
            }
        }

        private void btnRandInfo_Click(object sender, EventArgs e)
        {
            GenerateData();
        }

        void GenerateData() 
        {
            Random r = new Random();
            int ChineseScore = r.Next(0, 101);
            int EngScore = r.Next(0, 101);
            int MathScore = r.Next(0, 101);
            Total = ChineseScore + EngScore + MathScore;
            Avg = Total / 3;
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"國語", ChineseScore},
                {"英文", EngScore},
                {"數學", MathScore}
            };
            //----->Max
            var maxValueKey = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            var maxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
            //----->Max
            //----->Min
            var minValueKey = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
            var minValue = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
            //----->Min
            string[] row = {IDNumber.ToString(), ChineseScore.ToString(),  EngScore.ToString(), MathScore.ToString(),
                    Total.ToString(), Avg.ToString(), minValueKey + minValue, maxValueKey + maxValue};
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            IDNumber += 1;

        }

        private void btnSubjectStats_Click(object sender, EventArgs e)
        {
        }

        private void btnResetInfo_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            btnAddInfo.Enabled = true;
            btnRandInfo.Enabled = true;
            btnSubjectStats.Enabled = true;
            btnResetInfo.Enabled = true;
            IDNumber = 1;
        }

        private void btnRanAdd20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                GenerateData();
            }
        }
    }
}
