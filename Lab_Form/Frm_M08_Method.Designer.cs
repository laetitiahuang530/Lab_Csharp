namespace Lab_Form
{
    partial class Frm_M08_Method
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.btnArrMaxMin = new System.Windows.Forms.Button();
            this.btnArrC = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.labResult2 = new System.Windows.Forms.Label();
            this.btnArrOddEven = new System.Windows.Forms.Button();
            this.btnArrLongestString = new System.Windows.Forms.Button();
            this.btn2DArrayOut1In0 = new System.Windows.Forms.Button();
            this.btn2DArrayOut0In1 = new System.Windows.Forms.Button();
            this.btn2DArrAlter01 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labFrom = new System.Windows.Forms.Label();
            this.labTo = new System.Windows.Forms.Label();
            this.labStep = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.labRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.btnStarPyramid = new System.Windows.Forms.Button();
            this.btnMultTable = new System.Windows.Forms.Button();
            this.btn100Binary = new System.Windows.Forms.Button();
            this.btnLotteryNums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number: ";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(108, 21);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(115, 36);
            this.txtNum.TabIndex = 1;
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEvenOdd.Location = new System.Drawing.Point(32, 77);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(191, 46);
            this.btnEvenOdd.TabIndex = 2;
            this.btnEvenOdd.Text = "輸入的數為奇數或偶數?";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // btnArrMaxMin
            // 
            this.btnArrMaxMin.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrMaxMin.Location = new System.Drawing.Point(32, 129);
            this.btnArrMaxMin.Name = "btnArrMaxMin";
            this.btnArrMaxMin.Size = new System.Drawing.Size(191, 46);
            this.btnArrMaxMin.TabIndex = 3;
            this.btnArrMaxMin.Text = "陣列arr0711[]最大/小直";
            this.btnArrMaxMin.UseVisualStyleBackColor = true;
            this.btnArrMaxMin.Click += new System.EventHandler(this.btnArrMaxMin_Click);
            // 
            // btnArrC
            // 
            this.btnArrC.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArrC.Location = new System.Drawing.Point(32, 181);
            this.btnArrC.Name = "btnArrC";
            this.btnArrC.Size = new System.Drawing.Size(191, 47);
            this.btnArrC.TabIndex = 4;
            this.btnArrC.Text = "陣列arr0711_Str[]xue \"C\" OR \"c\"的字樣有幾個";
            this.btnArrC.UseVisualStyleBackColor = true;
            this.btnArrC.Click += new System.EventHandler(this.btnArrC_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(32, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空結果藍";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(30, 319);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(79, 24);
            this.labResult.TabIndex = 6;
            this.labResult.Text = "Result: ";
            // 
            // labResult2
            // 
            this.labResult2.AutoSize = true;
            this.labResult2.BackColor = System.Drawing.SystemColors.Info;
            this.labResult2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult2.Location = new System.Drawing.Point(115, 319);
            this.labResult2.Name = "labResult2";
            this.labResult2.Size = new System.Drawing.Size(39, 16);
            this.labResult2.TabIndex = 7;
            this.labResult2.Text = "結果";
            // 
            // btnArrOddEven
            // 
            this.btnArrOddEven.Location = new System.Drawing.Point(245, 23);
            this.btnArrOddEven.Name = "btnArrOddEven";
            this.btnArrOddEven.Size = new System.Drawing.Size(144, 33);
            this.btnArrOddEven.TabIndex = 8;
            this.btnArrOddEven.Text = "陣列arr0711[]統計奇偶數的";
            this.btnArrOddEven.UseVisualStyleBackColor = true;
            this.btnArrOddEven.Click += new System.EventHandler(this.btnArrOddEven_Click);
            // 
            // btnArrLongestString
            // 
            this.btnArrLongestString.Location = new System.Drawing.Point(245, 62);
            this.btnArrLongestString.Name = "btnArrLongestString";
            this.btnArrLongestString.Size = new System.Drawing.Size(144, 33);
            this.btnArrLongestString.TabIndex = 9;
            this.btnArrLongestString.Text = "陣列arr0711_Str[]最長的名字";
            this.btnArrLongestString.UseVisualStyleBackColor = true;
            this.btnArrLongestString.Click += new System.EventHandler(this.btnArrLongestString_Click);
            // 
            // btn2DArrayOut1In0
            // 
            this.btn2DArrayOut1In0.Location = new System.Drawing.Point(400, 24);
            this.btn2DArrayOut1In0.Name = "btn2DArrayOut1In0";
            this.btn2DArrayOut1In0.Size = new System.Drawing.Size(149, 33);
            this.btn2DArrayOut1In0.TabIndex = 10;
            this.btn2DArrayOut1In0.Text = "[10,10]二維陣列-邊1,內0";
            this.btn2DArrayOut1In0.UseVisualStyleBackColor = true;
            this.btn2DArrayOut1In0.Click += new System.EventHandler(this.btn2DArrayOut1In0_Click);
            // 
            // btn2DArrayOut0In1
            // 
            this.btn2DArrayOut0In1.Location = new System.Drawing.Point(400, 62);
            this.btn2DArrayOut0In1.Name = "btn2DArrayOut0In1";
            this.btn2DArrayOut0In1.Size = new System.Drawing.Size(149, 33);
            this.btn2DArrayOut0In1.TabIndex = 11;
            this.btn2DArrayOut0In1.Text = "[10,10]二維陣列-邊0,內1";
            this.btn2DArrayOut0In1.UseVisualStyleBackColor = true;
            this.btn2DArrayOut0In1.Click += new System.EventHandler(this.btn2DArrayOut0In1_Click);
            // 
            // btn2DArrAlter01
            // 
            this.btn2DArrAlter01.Location = new System.Drawing.Point(400, 101);
            this.btn2DArrAlter01.Name = "btn2DArrAlter01";
            this.btn2DArrAlter01.Size = new System.Drawing.Size(149, 74);
            this.btn2DArrAlter01.TabIndex = 12;
            this.btn2DArrAlter01.Text = "[10,10]二維陣列\r\n1010101010\r\n0101010101\r\n1010101010\r\n0101010101\r\n1010101010\r\n10101010" +
    "10\r\n0101010101\r\n1010101010\r\n0101010101\r\n1010101010\r\n";
            this.btn2DArrAlter01.UseVisualStyleBackColor = true;
            this.btn2DArrAlter01.Click += new System.EventHandler(this.btn2DArrAlter01_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(555, 23);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(185, 33);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "Swap[int, int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(555, 62);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(185, 33);
            this.btnSum.TabIndex = 14;
            this.btnSum.Text = "Sum(陣列arr0711[])";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(555, 101);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(185, 33);
            this.btnMax.TabIndex = 15;
            this.btnMax.Text = "Max(陣列arr0711[])";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(555, 140);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(185, 33);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "Min(陣列arr0711[])";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(243, 194);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(58, 19);
            this.labFrom.TabIndex = 17;
            this.labFrom.Text = "From: ";
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(255, 235);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(39, 19);
            this.labTo.TabIndex = 18;
            this.labTo.Text = "To: ";
            // 
            // labStep
            // 
            this.labStep.AutoSize = true;
            this.labStep.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStep.Location = new System.Drawing.Point(243, 273);
            this.labStep.Name = "labStep";
            this.labStep.Size = new System.Drawing.Size(51, 19);
            this.labStep.TabIndex = 19;
            this.labStep.Text = "Step: ";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(309, 192);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(80, 22);
            this.txtFrom.TabIndex = 20;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(309, 234);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(80, 22);
            this.txtTo.TabIndex = 21;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(309, 275);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(80, 22);
            this.txtStep.TabIndex = 22;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.Info;
            this.btnFor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFor.Location = new System.Drawing.Point(395, 186);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(76, 31);
            this.btnFor.TabIndex = 23;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.Info;
            this.btnWhile.Location = new System.Drawing.Point(395, 228);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(76, 31);
            this.btnWhile.TabIndex = 24;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.Info;
            this.btnDo.Location = new System.Drawing.Point(395, 275);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(76, 31);
            this.btnDo.TabIndex = 25;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // labRows
            // 
            this.labRows.AutoSize = true;
            this.labRows.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRows.Location = new System.Drawing.Point(492, 192);
            this.labRows.Name = "labRows";
            this.labRows.Size = new System.Drawing.Size(60, 19);
            this.labRows.TabIndex = 26;
            this.labRows.Text = "Rows: ";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(555, 189);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(83, 22);
            this.txtRows.TabIndex = 27;
            // 
            // btnStarPyramid
            // 
            this.btnStarPyramid.BackColor = System.Drawing.SystemColors.Info;
            this.btnStarPyramid.Location = new System.Drawing.Point(496, 224);
            this.btnStarPyramid.Name = "btnStarPyramid";
            this.btnStarPyramid.Size = new System.Drawing.Size(117, 30);
            this.btnStarPyramid.TabIndex = 28;
            this.btnStarPyramid.Text = "直角聖誕樹";
            this.btnStarPyramid.UseVisualStyleBackColor = false;
            this.btnStarPyramid.Click += new System.EventHandler(this.btnStarPyramid_Click);
            // 
            // btnMultTable
            // 
            this.btnMultTable.BackColor = System.Drawing.SystemColors.Info;
            this.btnMultTable.Location = new System.Drawing.Point(496, 268);
            this.btnMultTable.Name = "btnMultTable";
            this.btnMultTable.Size = new System.Drawing.Size(117, 29);
            this.btnMultTable.TabIndex = 29;
            this.btnMultTable.Text = "九九乘法表";
            this.btnMultTable.UseVisualStyleBackColor = false;
            this.btnMultTable.Click += new System.EventHandler(this.btnMultTable_Click);
            // 
            // btn100Binary
            // 
            this.btn100Binary.BackColor = System.Drawing.SystemColors.Info;
            this.btn100Binary.Location = new System.Drawing.Point(650, 187);
            this.btn100Binary.Name = "btn100Binary";
            this.btn100Binary.Size = new System.Drawing.Size(125, 32);
            this.btn100Binary.TabIndex = 30;
            this.btn100Binary.Text = "100的二進位是?";
            this.btn100Binary.UseVisualStyleBackColor = false;
            this.btn100Binary.Click += new System.EventHandler(this.btn100Binary_Click);
            // 
            // btnLotteryNums
            // 
            this.btnLotteryNums.BackColor = System.Drawing.SystemColors.Info;
            this.btnLotteryNums.Location = new System.Drawing.Point(650, 225);
            this.btnLotteryNums.Name = "btnLotteryNums";
            this.btnLotteryNums.Size = new System.Drawing.Size(125, 32);
            this.btnLotteryNums.TabIndex = 31;
            this.btnLotteryNums.Text = "樂透int[]號碼不重";
            this.btnLotteryNums.UseVisualStyleBackColor = false;
            this.btnLotteryNums.Click += new System.EventHandler(this.btnLotteryNums_Click);
            // 
            // Frm_M08_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.btnLotteryNums);
            this.Controls.Add(this.btn100Binary);
            this.Controls.Add(this.btnMultTable);
            this.Controls.Add(this.btnStarPyramid);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.labRows);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.labStep);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn2DArrAlter01);
            this.Controls.Add(this.btn2DArrayOut0In1);
            this.Controls.Add(this.btn2DArrayOut1In0);
            this.Controls.Add(this.btnArrLongestString);
            this.Controls.Add(this.btnArrOddEven);
            this.Controls.Add(this.labResult2);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnArrC);
            this.Controls.Add(this.btnArrMaxMin);
            this.Controls.Add(this.btnEvenOdd);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Frm_M08_Method";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ForDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.Button btnArrMaxMin;
        private System.Windows.Forms.Button btnArrC;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labResult2;
        private System.Windows.Forms.Button btnArrOddEven;
        private System.Windows.Forms.Button btnArrLongestString;
        private System.Windows.Forms.Button btn2DArrayOut1In0;
        private System.Windows.Forms.Button btn2DArrayOut0In1;
        private System.Windows.Forms.Button btn2DArrAlter01;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.Label labStep;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label labRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button btnStarPyramid;
        private System.Windows.Forms.Button btnMultTable;
        private System.Windows.Forms.Button btn100Binary;
        private System.Windows.Forms.Button btnLotteryNums;
    }
}