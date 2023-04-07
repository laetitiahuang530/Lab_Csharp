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
    public partial class Frm_22 : Form
    {
        public Frm_22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            while (i < 10)
            {
                result += i++ + "\n";
            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            do
            {
                result += i++ + "\n";
            } while (i < 10);
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("家裡有沒有蟑螂?", "蟑螂問題",
                MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("要時常打掃環境");
                    break;
                case DialogResult.No:
                    MessageBox.Show("還是要保持居家環境的整潔");
                    break;
                default:
                    MessageBox.Show("Default");
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0, x = 100, y =50; (x-y) > i; i++, x--, y += 2)
            {
                result += $"i:{i:D2}, x:{x:D3}, y:{y}\n";
            }
            MessageBox.Show(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Member[] arrMember = new Member[2];
            arrMember[0] = new Member();
            arrMember[0].Name = "John";
            arrMember[0].Age = 30;
            arrMember[1] = new Member();
            arrMember[1].Name = "Wick";
            arrMember[1].Age = 40;

            string result = "";

            for (int i = 0; i < arrMember.Length; i++)
            {
                result += $"{arrMember[i].Name}, {arrMember[i].Age}\n";
            }
            MessageBox.Show(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] newarr = CreateNewArray(20);
            string result = "";
            int i = 0;
            foreach(int item in newarr)
            {
                result += $"newarr[{i}]={item}\n";
                i++;
            }
            //for (int i = 0; i < newarr.Length; i++)
            //{
            //    result += $"newarr[{i}]={newarr[i]}\n";
            //}
            MessageBox.Show(result);
        }
        int[] CreateNewArray(int Len)
        {
            int[] arr = new int[Len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] {1, 2, 3};
            arr[1] = new int[] { 1, 2, 3, 4, 5 };
            arr[2] = new int[] { 1, 2 };
            string result = "";
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0; j < arr[i].Length; j++)
                {
                    //result += " " + arr[i, j] + "\n";
                }
            }
        }
    }
}
