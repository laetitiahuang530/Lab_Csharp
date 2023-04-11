using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_Form.Employee;

namespace Lab_Form
{
    public partial class Frm_24 : Form
    {
        public Frm_24()
        {
            InitializeComponent();
        }
        List<Product> IsPro = new List<Product>();
        void ShowProductList()
        {
            decimal totalPrice = 0;
            label1.Text = "產品\n";
            //for (int i = 0; i < IsPro.Count; i++)
            //{
            //    label3.Text += $"名稱:{((Product)IsPro[i]).Name}" +
            //        $", 單價:{((Product)IsPro[i])}.Price\n";
            //    totalPrice += ((Product)IsPro[i]).Price;
            //}
            foreach(Product pro in IsPro)
            {
                label3.Text += $"名稱:{pro.Name}" +
                    $", 單價:{pro.Price}\n";
                totalPrice += pro.Price;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = textBox1.Text;
            pro.Price = decimal.Parse(textBox2.Text);
            IsPro.Add(pro);
            label3.Text = "產品\n";
            for (int i = 0; i < IsPro.Count; i++) {
                label3.Text += $"名稱: {((Product)IsPro[i]).Name},單價: {((Product)IsPro[i]).Price}\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = textBox1.Text;
            pro.Price = decimal.Parse(textBox2.Text);
            IsPro.Insert(0,pro);
            label3.Text = "產品\n";
            for (int i = 0; i < IsPro.Count; i++)
            {
                label3.Text += $"名稱: {((Product)IsPro[i]).Name},單價: {((Product)IsPro[i]).Price}\n";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IsPro.Clear();
            label3.Text = "產品\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsPro.RemoveAt(0);
            label3.Text = "產品\n";
            for (int i = 0; i < IsPro.Count; i++)
            {
                label3.Text += $"名稱: {((Product)IsPro[i]).Name},單價: {((Product)IsPro[i]).Price}\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = "Laetitia";
            product.Price = 34098;
            IsPro.Add(product);
            ShowProductList();
        }
    }
}
