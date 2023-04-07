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
    public partial class Frm_M03_LoanForm : Form
    {
        public Frm_M03_LoanForm()
        {
            InitializeComponent();
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            double loanAmount = Double.Parse(txtLoanAmount.Text);
            double interest = Double.Parse(Interest.Text);
            double expYear = Double.Parse(txtExpYear.Text);
            double monthlyInterest = interest / 1200;
            double expMonth = expYear * 12;
            double downPayment = Double.Parse(txtDownPayment.Text);
            double pmt = Math.Round((loanAmount- downPayment) *((Math.Pow(1 + monthlyInterest, expMonth) * monthlyInterest) / (Math.Pow(1 + monthlyInterest, expMonth) -1)));
            MessageBox.Show("月付額: " + pmt.ToString() + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double loanAmount = Double.Parse(txtLoanAmount.Text);
            double interest = Double.Parse(Interest.Text);
            double expYear = Double.Parse(txtExpYear.Text);
            double monthlyInterest = interest / 1200;
            double expMonth = expYear * 12;
            double downPayment = Double.Parse(txtDownPayment.Text);
            double pmt = Math.Round((loanAmount - downPayment) * ((Math.Pow(1 + monthlyInterest, expMonth) * monthlyInterest) / (Math.Pow(1 + monthlyInterest, expMonth) - 1)));
            double total = pmt * expMonth;
            MessageBox.Show("總付款: " + total.ToString() + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            double loanAmount = Double.Parse(txtLoanAmount.Text);
            double interest = Double.Parse(Interest.Text);
            double expYear = Double.Parse(txtExpYear.Text);
            double monthlyInterest = interest / 1200;
            double expMonth = expYear * 12;
            double downPayment = Double.Parse(txtDownPayment.Text);
            double pmt = Math.Round((loanAmount - downPayment) * ((Math.Pow(1 + monthlyInterest, expMonth) * monthlyInterest) / (Math.Pow(1 + monthlyInterest, expMonth) - 1)));
            double total = pmt * expMonth;
            Frm_M04_LoanReportForm frmReport = new Frm_M04_LoanReportForm(txtLoanAmount.Text,txtExpYear.Text,Interest.Text, pmt.ToString(),total.ToString());
            frmReport.Show();
        }
    }
}
