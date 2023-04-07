namespace Lab_Form
{
    partial class Frm_M05_POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M05_POSForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhiskey = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "總金額 Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "付款方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "購物清單 List";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnWine);
            this.panel1.Controls.Add(this.btnWhiskey);
            this.panel1.Controls.Add(this.btnTequila);
            this.panel1.Controls.Add(this.btnBeer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 415);
            this.panel1.TabIndex = 4;
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWine.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWine.Location = new System.Drawing.Point(177, 220);
            this.btnWine.Margin = new System.Windows.Forms.Padding(4);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(147, 160);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhiskey
            // 
            this.btnWhiskey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhiskey.BackgroundImage")));
            this.btnWhiskey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhiskey.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhiskey.Location = new System.Drawing.Point(21, 220);
            this.btnWhiskey.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhiskey.Name = "btnWhiskey";
            this.btnWhiskey.Size = new System.Drawing.Size(147, 160);
            this.btnWhiskey.TabIndex = 3;
            this.btnWhiskey.Text = "威士忌\r\nWhiskey\r\nNT$350";
            this.btnWhiskey.UseVisualStyleBackColor = true;
            this.btnWhiskey.Click += new System.EventHandler(this.btnWhiskey_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTequila.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTequila.Location = new System.Drawing.Point(177, 52);
            this.btnTequila.Margin = new System.Windows.Forms.Padding(4);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(147, 160);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeer.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBeer.Location = new System.Drawing.Point(15, 52);
            this.btnBeer.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(147, 160);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜單 Menu";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(387, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 125);
            this.panel2.TabIndex = 5;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalPrice.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(9, 51);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(355, 52);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "$0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnCredit);
            this.panel3.Controls.Add(this.btnCash);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(387, 195);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 178);
            this.panel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(282, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "信用卡享九折!";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(200, 51);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(153, 49);
            this.btnCredit.TabIndex = 2;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(20, 51);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(152, 49);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.txtList);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(788, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 414);
            this.panel4.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 347);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 48);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.Location = new System.Drawing.Point(21, 48);
            this.txtList.Margin = new System.Windows.Forms.Padding(4);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(304, 289);
            this.txtList.TabIndex = 1;
            this.txtList.Text = "尚未點餐";
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_M05_POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M05_POSForm";
            this.Text = "Frm_M05_POSForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhiskey;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtList;
    }
}