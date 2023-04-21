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
    public partial class Frm_M05_POSForm : Form
    {
        int beer;
        int tequila;
        int whiskey;
        int wine;
        private int beerCnt;
        private int tequilaCnt;
        private int whiskeyCnt;
        private int wineCnt;
        int total;
        public Frm_M05_POSForm()
        {
            InitializeComponent();
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            beer += 120;
            beerCnt += 1;
            total = beer + tequila + whiskey + wine;
            txtTotalPrice.Text = "NT$ " + total.ToString();
            txtListshow();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            tequila += 180;
            tequilaCnt += 1;
            total = beer + tequila + whiskey + wine;
            txtTotalPrice.Text = "NT$ " + total.ToString();
            txtListshow();
        }

        private void btnWhiskey_Click(object sender, EventArgs e)
        {
            whiskey += 350;
            whiskeyCnt += 1;
            total = beer + tequila + whiskey + wine;
            txtTotalPrice.Text = "NT$ " + total.ToString();
            txtListshow();

        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            wine += 320;
            wineCnt += 1;
            total = beer + tequila + whiskey + wine;
            txtTotalPrice.Text = "NT$ " + total.ToString();
            txtListshow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            beer = 0;
            tequila = 0;
            whiskey = 0;
            wine = 0;
            total = 0;
            beerCnt = 0;
            tequilaCnt = 0;
            whiskeyCnt = 0;
            wineCnt = 0;
            txtTotalPrice.Text = "NT$ " + total.ToString();
            txtList.Text = "尚未點餐";
        }

        private void txtListshow()
        {
            string output = "";

            if (beerCnt > 0)
            {
                output += "啤酒Beer x" + beerCnt + ",共NT$ " + beer + "元\r\n";
            }
            if (tequilaCnt > 0)
            {
                output += "龍舌蘭Tequila x" + tequilaCnt + ",共NT$ " + tequila + "元\r\n";
            }
            if (whiskey > 0)
            {
                output += "威士忌Whiskey x" + whiskeyCnt + ",共NT$ " + whiskey + "元\r\n";
            }
            if (wineCnt > 0)
            {
                output += "紅酒Wine x" + wineCnt + ",共NT$ " + wine + "元\r\n";
            }

            txtList.Text = output;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (total== 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("總金額: NT$" + total, "確認付款", MessageBoxButtons.OKCancel);

        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double discount = total * 0.9;
            MessageBox.Show("總金額: NT$" + total + "\n" + "折扣後金額: NT$" + discount, "確認付款", MessageBoxButtons.OKCancel);
        }
    }
}
