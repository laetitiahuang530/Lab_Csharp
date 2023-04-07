namespace Lab_Form
{
    partial class Frm_M07_StudentsGrade
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelChinese = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnRandInfo = new System.Windows.Forms.Button();
            this.btnSubjectStats = new System.Windows.Forms.Button();
            this.btnResetInfo = new System.Windows.Forms.Button();
            this.btnRanAdd20 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.Location = new System.Drawing.Point(27, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名 : ";
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelChinese.Location = new System.Drawing.Point(27, 89);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(51, 16);
            this.labelChinese.TabIndex = 1;
            this.labelChinese.Text = "國文 : ";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEnglish.Location = new System.Drawing.Point(27, 135);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(51, 16);
            this.labelEnglish.TabIndex = 2;
            this.labelEnglish.Text = "英文 : ";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMath.Location = new System.Drawing.Point(27, 179);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(51, 16);
            this.labelMath.TabIndex = 3;
            this.labelMath.Text = "數學 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 22);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(84, 75);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(104, 30);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(84, 123);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(104, 28);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(84, 167);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(104, 28);
            this.txtMath.TabIndex = 7;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddInfo.Location = new System.Drawing.Point(30, 219);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(150, 28);
            this.btnAddInfo.TabIndex = 8;
            this.btnAddInfo.Text = "加入學生資料";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnRandInfo
            // 
            this.btnRandInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandInfo.Location = new System.Drawing.Point(30, 263);
            this.btnRandInfo.Name = "btnRandInfo";
            this.btnRandInfo.Size = new System.Drawing.Size(150, 30);
            this.btnRandInfo.TabIndex = 9;
            this.btnRandInfo.Text = "隨機儲存資料";
            this.btnRandInfo.UseVisualStyleBackColor = true;
            this.btnRandInfo.Click += new System.EventHandler(this.btnRandInfo_Click);
            // 
            // btnSubjectStats
            // 
            this.btnSubjectStats.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubjectStats.Location = new System.Drawing.Point(30, 308);
            this.btnSubjectStats.Name = "btnSubjectStats";
            this.btnSubjectStats.Size = new System.Drawing.Size(150, 25);
            this.btnSubjectStats.TabIndex = 10;
            this.btnSubjectStats.Text = "各科統計";
            this.btnSubjectStats.UseVisualStyleBackColor = true;
            this.btnSubjectStats.Click += new System.EventHandler(this.btnSubjectStats_Click);
            // 
            // btnResetInfo
            // 
            this.btnResetInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnResetInfo.Location = new System.Drawing.Point(30, 359);
            this.btnResetInfo.Name = "btnResetInfo";
            this.btnResetInfo.Size = new System.Drawing.Size(150, 29);
            this.btnResetInfo.TabIndex = 11;
            this.btnResetInfo.Text = "重設所有資料";
            this.btnResetInfo.UseVisualStyleBackColor = true;
            this.btnResetInfo.Click += new System.EventHandler(this.btnResetInfo_Click);
            // 
            // btnRanAdd20
            // 
            this.btnRanAdd20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRanAdd20.Location = new System.Drawing.Point(29, 403);
            this.btnRanAdd20.Name = "btnRanAdd20";
            this.btnRanAdd20.Size = new System.Drawing.Size(150, 27);
            this.btnRanAdd20.TabIndex = 12;
            this.btnRanAdd20.Text = "隨機加入20筆";
            this.btnRanAdd20.UseVisualStyleBackColor = true;
            this.btnRanAdd20.Click += new System.EventHandler(this.btnRanAdd20_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(197, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 255);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "總分";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "平均";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "最低";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "最高";
            this.columnHeader8.Width = 65;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(197, 288);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(569, 142);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Frm_M07_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRanAdd20);
            this.Controls.Add(this.btnResetInfo);
            this.Controls.Add(this.btnSubjectStats);
            this.Controls.Add(this.btnRandInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelChinese);
            this.Controls.Add(this.labelName);
            this.Name = "Frm_M07_StudentsGrade";
            this.Text = "Frm_M07_StudentsGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnRandInfo;
        private System.Windows.Forms.Button btnSubjectStats;
        private System.Windows.Forms.Button btnResetInfo;
        private System.Windows.Forms.Button btnRanAdd20;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listView2;
    }
}