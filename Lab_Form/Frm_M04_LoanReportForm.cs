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
    public partial class Frm_M04_LoanReportForm : Form
    {
        public Frm_M04_LoanReportForm(string data1, string data2, string data3, string data4, string data5)
        {
            InitializeComponent();

            label1.Text = data1;
            label2.Text = data2;
            label3.Text = data3;
            label4.Text = data4;
            label5.Text = data5;
        }
    }
}
