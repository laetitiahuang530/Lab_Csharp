namespace Lab_Form
{
    partial class Frm_M07_1_StudentsGradeList
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
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAddStudentInfo = new System.Windows.Forms.Button();
            this.btnInsertStudentInfo = new System.Windows.Forms.Button();
            this.btnRemoveStudentInfo = new System.Windows.Forms.Button();
            this.btnClearAllInfo = new System.Windows.Forms.Button();
            this.labSearchChineseScreRange = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labDash = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAverage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(23, 12);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名 :";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(23, 47);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(51, 16);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文 : ";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(23, 78);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(51, 16);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文 : ";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(23, 111);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(51, 16);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(76, 47);
            this.txtChinese.Multiline = true;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(95, 25);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(76, 78);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(95, 27);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(76, 111);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(95, 27);
            this.txtMath.TabIndex = 7;
            // 
            // btnAddStudentInfo
            // 
            this.btnAddStudentInfo.Location = new System.Drawing.Point(26, 150);
            this.btnAddStudentInfo.Name = "btnAddStudentInfo";
            this.btnAddStudentInfo.Size = new System.Drawing.Size(143, 31);
            this.btnAddStudentInfo.TabIndex = 8;
            this.btnAddStudentInfo.Text = "加入學生資料";
            this.btnAddStudentInfo.UseVisualStyleBackColor = true;
            this.btnAddStudentInfo.Click += new System.EventHandler(this.btnAddStudentInfo_Click);
            // 
            // btnInsertStudentInfo
            // 
            this.btnInsertStudentInfo.Location = new System.Drawing.Point(26, 187);
            this.btnInsertStudentInfo.Name = "btnInsertStudentInfo";
            this.btnInsertStudentInfo.Size = new System.Drawing.Size(143, 31);
            this.btnInsertStudentInfo.TabIndex = 9;
            this.btnInsertStudentInfo.Text = "插入儲存資料";
            this.btnInsertStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudentInfo
            // 
            this.btnRemoveStudentInfo.Enabled = false;
            this.btnRemoveStudentInfo.Location = new System.Drawing.Point(26, 224);
            this.btnRemoveStudentInfo.Name = "btnRemoveStudentInfo";
            this.btnRemoveStudentInfo.Size = new System.Drawing.Size(143, 31);
            this.btnRemoveStudentInfo.TabIndex = 10;
            this.btnRemoveStudentInfo.Text = "移除學生資料";
            this.btnRemoveStudentInfo.UseVisualStyleBackColor = true;
            // 
            // btnClearAllInfo
            // 
            this.btnClearAllInfo.Location = new System.Drawing.Point(26, 261);
            this.btnClearAllInfo.Name = "btnClearAllInfo";
            this.btnClearAllInfo.Size = new System.Drawing.Size(143, 31);
            this.btnClearAllInfo.TabIndex = 11;
            this.btnClearAllInfo.Text = "清除所有資料";
            this.btnClearAllInfo.UseVisualStyleBackColor = true;
            // 
            // labSearchChineseScreRange
            // 
            this.labSearchChineseScreRange.AutoSize = true;
            this.labSearchChineseScreRange.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSearchChineseScreRange.Location = new System.Drawing.Point(24, 305);
            this.labSearchChineseScreRange.Name = "labSearchChineseScreRange";
            this.labSearchChineseScreRange.Size = new System.Drawing.Size(147, 16);
            this.labSearchChineseScreRange.TabIndex = 12;
            this.labSearchChineseScreRange.Text = "搜尋國文成績範圍 : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 338);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 36);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(116, 338);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 36);
            this.textBox6.TabIndex = 14;
            // 
            // labDash
            // 
            this.labDash.AutoSize = true;
            this.labDash.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDash.Location = new System.Drawing.Point(90, 338);
            this.labDash.Name = "labDash";
            this.labDash.Size = new System.Drawing.Size(20, 27);
            this.labDash.TabIndex = 15;
            this.labDash.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(29, 383);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colChinese,
            this.colEnglish,
            this.colMath,
            this.colTotal,
            this.colAverage,
            this.colMin,
            this.colMax});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(189, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(599, 238);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Location = new System.Drawing.Point(189, 271);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(598, 139);
            this.textBox7.TabIndex = 18;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            // 
            // colChinese
            // 
            this.colChinese.Text = "國文";
            this.colChinese.Width = 70;
            // 
            // colEnglish
            // 
            this.colEnglish.Text = "英文";
            // 
            // colMath
            // 
            this.colMath.Text = "數學";
            // 
            // colTotal
            // 
            this.colTotal.Text = "總分";
            // 
            // colAverage
            // 
            this.colAverage.Text = "平均";
            // 
            // colMin
            // 
            this.colMin.Text = "最低";
            // 
            // colMax
            // 
            this.colMax.Text = "最高";
            // 
            // Frm_M07_1_StudentsGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labDash);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labSearchChineseScreRange);
            this.Controls.Add(this.btnClearAllInfo);
            this.Controls.Add(this.btnRemoveStudentInfo);
            this.Controls.Add(this.btnInsertStudentInfo);
            this.Controls.Add(this.btnAddStudentInfo);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "Frm_M07_1_StudentsGradeList";
            this.Text = "Frm_M07_1_StudentsGradeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAddStudentInfo;
        private System.Windows.Forms.Button btnInsertStudentInfo;
        private System.Windows.Forms.Button btnRemoveStudentInfo;
        private System.Windows.Forms.Button btnClearAllInfo;
        private System.Windows.Forms.Label labSearchChineseScreRange;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labDash;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colChinese;
        private System.Windows.Forms.ColumnHeader colEnglish;
        private System.Windows.Forms.ColumnHeader colMath;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colAverage;
        private System.Windows.Forms.ColumnHeader colMin;
        private System.Windows.Forms.ColumnHeader colMax;
        private System.Windows.Forms.TextBox textBox7;
    }
}