﻿using System;
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
    public partial class Frm_M26_Array : Form
    {
        public Frm_M26_Array()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5] {1, 2, 3, 4, 5};
            string result = "";
            for (int i = 0; i < arr.Length; i++) {
                result += arr[i] + " ";
            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr =
            {
                {1, 2, 3},
                {1, 2, 3}
            };
            string result = "";
            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += $"arr[{i}, {j}] => {arr[i, j]}\n";
                }
            }
            MessageBox.Show(result);
        }
    }
}
