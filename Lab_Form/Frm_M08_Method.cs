using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M08_Method : Form
    {
        public Frm_M08_Method()
        {
            InitializeComponent();
        }
        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            string txtnum = txtNum.Text;
            int num;
            bool isNum = int.TryParse(txtnum, out num);
            if (isNum)
            {
                if (num % 2 == 0)
                {
                    labResult2.Text = "輸入的數 " + num.ToString() + " 為偶數。";
                }
                else
                {
                    labResult2.Text = "輸入的數 " + num.ToString() + " 為奇數。";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnArrMaxMin_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            int min = arr0711.Min();
            labResult2.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為{max}\n最小值為{min}";
        }

        private void btnArrC_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string str in arr0711_Str)
            {
                if (str.Contains('C') || str.Contains('c'))
                {
                    count++;
                }
            }
            labResult2.Text = "arr0711_Str陣列: " + string.Join(" ", arr0711_Str) + "\n有C 及 c的名字共有" + count.ToString() + "個";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult2.Text = "結果";
        }

        private void btnArrOddEven_Click(object sender, EventArgs e)
        {
            int evenCnt = 0;
            int oddCnt = 0;
            foreach (int n in arr0711)
            {
                if (n % 2 == 0)
                {
                    evenCnt++;
                }
                else
                {
                    oddCnt++;
                }
            }
            labResult2.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共{oddCnt}\n偶數共{evenCnt}";
        }

        private void btnArrLongestString_Click(object sender, EventArgs e)
        {
            string longestString = "";
            foreach (string s in arr0711_Str)
            {
                if (s.Length > arr0711_Str.Length)
                {
                    longestString = s;
                }
            }
            labResult2.Text = "陣列arr0711_Str [" + string.Join(",", arr0711_Str) + $"]\n最長的名字為{longestString}";
        }

        private void btn2DArrayOut1In0_Click(object sender, EventArgs e)
        {
            int[,] arr_2D = new int[10, 10]
            {
               { 1,1,1,1,1,1,1,1,1,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,0,0,0,0,0,0,0,0,1},
               { 1,1,1,1,1,1,1,1,1,1}
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr_2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2D.GetLength(1); j++)
                {
                    sb.Append(arr_2D[i, j] + " ");
                }
                sb.AppendLine();
            }
            labResult2.Text = sb.ToString();

        }

        private void btn2DArrayOut0In1_Click(object sender, EventArgs e)
        {
            int[,] arr_2D = new int[10, 10]
            {
               { 0,0,0,0,0,0,0,0,0,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,1,1,1,1,1,1,1,1,0},
               { 0,0,0,0,0,0,0,0,0,0}
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr_2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2D.GetLength(1); j++)
                {
                    sb.Append(arr_2D[i, j] + " ");
                }
                sb.AppendLine();
            }
            labResult2.Text = sb.ToString();
        }
        private void btn2DArrAlter01_Click(object sender, EventArgs e)
        {
            int[,] arr_2D = new int[10, 10]
            {
               { 1,0,1,0,1,0,1,0,1,0},
               { 0,1,0,1,0,1,0,1,0,1},
               { 1,0,1,0,1,0,1,0,1,0},
               { 0,1,0,1,0,1,0,1,0,1},
               { 1,0,1,0,1,0,1,0,1,0},
               { 0,1,0,1,0,1,0,1,0,1},
               { 1,0,1,0,1,0,1,0,1,0},
               { 0,1,0,1,0,1,0,1,0,1},
               { 1,0,1,0,1,0,1,0,1,0},
               { 0,1,0,1,0,1,0,1,0,1}
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr_2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2D.GetLength(1); j++)
                {
                    sb.Append(arr_2D[i, j] + " ");
                }
                sb.AppendLine();
            }
            labResult2.Text = sb.ToString();
        }
        private void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            labResult2.Text = $"換位前{n1} , {n2}\r\n";
            Swap(ref n1, ref n2);
            labResult2.Text += $"換位後{n1} , {n2}\r\n";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            labResult2.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n加總為 {arr0711.Sum()}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            labResult2.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最大值為 {arr0711.Max()}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            labResult2.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\r\n最小值為 {arr0711.Min()}";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int start)
                && int.TryParse(txtTo.Text, out int to)
                && int.TryParse(txtStep.Text, out int step))
            {
                int total = 0;
                for (int i = start; i < to; i += step)
                {
                    total += i;
                }
                labResult2.Text = $"{start} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int start)
                && int.TryParse(txtTo.Text, out int to)
                && int.TryParse(txtStep.Text, out int step))
            {
                int total = 0;
                int i = start;
                while (i < to)
                {
                    total += i;
                    i += step;
                }
                labResult2.Text = $"{start} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int start)
                && int.TryParse(txtTo.Text, out int to)
                && int.TryParse(txtStep.Text, out int step))
            {
                int total = 0;
                int i = start;
                do
                {
                    total += i;
                    i += step;
                } while (i < to);
                labResult2.Text = $"{start} 到 {to} 相隔 {step - 1}\r\n加總為 {total}";

            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnStarPyramid_Click(object sender, EventArgs e)
        {
            string starPyramid = "";
            if (int.TryParse(txtRows.Text, out int row))
            {
                for (int i = 1; i <= row; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        starPyramid += "*";
                    }
                    starPyramid += "\n";
                }
                labResult2.Text = starPyramid;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnMultTable_Click(object sender, EventArgs e)
        {
            labResult2.Text = "九九乘法表\n";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if (j*i < 10)
                    {
                        labResult2.Text += $" {j}x {i}=  {j * i}|";
                    } else
                    {
                        labResult2.Text += $" {j}x {i}= {j*i}|";
                    }
                }
                labResult2.Text += "\n";
            }
        }

        private void btn100Binary_Click(object sender, EventArgs e)
        {
            labResult2.Text = Convert.ToString(100, 2);
        }

        private void btnLotteryNums_Click(object sender, EventArgs e)
        {
            labResult2.Text = "樂透號碼\n";
            Random r = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = r.Next(0, 100);
                labResult2.Text += " " + randomNumber.ToString();
            }
        }
    }
}
